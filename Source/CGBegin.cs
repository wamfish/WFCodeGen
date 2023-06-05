//  Copyright (C) 2023 - Present John Roscoe Hamilton - All Rights Reserved
//  You may use, distribute and modify this code under the terms of the MIT license.
//  See the file License.txt in the root folder for full license details.
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.IO;
using WFLib;

namespace WFCodeGen;
public class CGBegin
{
    const string DONOTEDITSTART = "//--Do Not Edit Start";
    const string DONOTEDITEND = "//--Do Not Edit End";
    public bool Run()
    {
        List<SourceFile> files = new List<SourceFile>();
        if (!Directory.Exists(Config.BackupDir))
        {
            Log($"Dir! {Config.BackupDir} not found");
            return false;
        }
       
        var sourceDirs = Directory.GetDirectories(Config.DataDefsDir);
        foreach(var dir in sourceDirs) 
        { 
            var nameSpace = Path.GetFileName(dir);
            var outputMain = Path.Combine(Config.MainDir, nameSpace); 
            if (!Directory.Exists(outputMain))
            {
                Log($"Skipping! {nameSpace}");
                Log($"Dir! {outputMain} not found");
                continue;
            }
            Log($"Working on! {nameSpace}");
            var sourceFiles = Directory.GetFiles(dir, "*.cs");
            foreach(var file in sourceFiles)
            {
                var sf = new SourceFile(file, File.ReadAllText(file), nameSpace);
                files.Add(sf);
                sf.AddGeneratedFile(GeneratedFileName(sf,  Path.GetFileNameWithoutExtension(file),".def.cs"), sf.Source, null, null);
                Log($"File! {file}");
                ParseCDS(sf);
            }
            sourceFiles = Directory.GetFiles(dir, "*.lnk");
            foreach (var file in sourceFiles)
            {
                var lnkFile = Path.GetFileNameWithoutExtension(file) + ".cs";
                var lnkText = File.ReadAllText(file).Trim();
                var srcPath = Path.Combine(Config.DataDefsDir, lnkText);
                srcPath = Path.Combine(srcPath, lnkFile);
                var sf = new SourceFile(file, File.ReadAllText(srcPath), nameSpace);
                if (File.Exists(srcPath)) 
                {
                    files.Add(sf);
                    sf.AddGeneratedFile(GeneratedFileName(sf, Path.GetFileNameWithoutExtension(file), ".def.cs"), sf.Source, null, null);
                    Log($"File! {file}");
                    ParseCDS(sf);
                }
                else
                {
                    LogError($"Linked File: {srcPath} not found");
                }
            }
        }
        OtherGenerators(files);
        WriteFiles(files);
        return true;
    }
    void OtherGenerators(List<SourceFile> files)
    {
        var filesWithGen = files.Where(f => f.HasGenerationTarget).ToList();
        foreach(var file in filesWithGen)
        {
            foreach(var gf in file.GeneratedFiles)
            {
                if (gf.Data == null) continue;
                foreach(var gen in Config.OtherGenerators)
                {
                    var sf  = gen.Run(gf.Data, file.Namespace);
                    if (sf == null) continue;
                    files.Add(sf);
                }
            }
        }
    }
    private void ParseCDS(SourceFile sf)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(sf.Source, path: sf.FileName);
        var cdsList = syntaxTree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().ToList();
        foreach (var cds in cdsList)
        {
            if (cds.BaseList == null) continue; //niothing to do for this class
            var sbt = cds.BaseList.ChildNodes().OfType<SimpleBaseTypeSyntax>().First();
            var nameNodes = sbt.ChildNodes().OfType<IdentifierNameSyntax>();
            if (nameNodes.Count() < 1) continue;
            var ins = nameNodes.First();
            string className;
            if (ins.Identifier.ValueText == "Record")
            {
                className = cds.Identifier.ValueText;
                object instance = GetInstance(className);
                if (instance == null || !(instance is Record rec))
                {
                    LogError($"Record! {className} is not a Record");
                    sf.Errors.Add($"Record! {className} is not a Record");
                    continue;
                }
                var srcPath = Path.Combine(Config.LocalGenDir, className + ".gen.cs");
                sf.AddGeneratedFile(GeneratedFileName(sf, className, ".gen.cs"), File.ReadAllText(srcPath) , cds, rec);
                Log($"Found Record! {className}");
                continue;
            }
            if (ins.Identifier.ValueText == "Data" && cds.Identifier.ToString() != "Record")
            {
                className = cds.Identifier.ValueText;
                object instance = GetInstance(className);
                if (instance == null || !(instance is Data data))
                {
                    LogError($"Data! {className} is not a Data");
                    sf.Errors.Add($"Data! {className} is not a Data");
                    continue;
                }
                var srcPath = Path.Combine(Config.LocalGenDir, className + ".gen.cs");
                sf.AddGeneratedFile(GeneratedFileName(sf, className, ".gen.cs"), File.ReadAllText(srcPath), cds, data);
                Log($"Found Data! {className}");
                continue;
            }
        }
    }
    public static string GeneratedFileName(SourceFile sf, string className, string ext)
    {
        string path = Path.Combine(Config.MainDir, sf.Namespace);
        path = Path.Combine(path, "Generated");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        path = Path.Combine(path, className + ext);
        return path;
    }
    public object GetInstance(string className)
    {
        try
        {
            var type = Type.GetType("WFCodeGen." + className);
            object instance = Activator.CreateInstance(type);
            return instance;
        }
        catch (Exception)
        {
            return null;
        }
    }
    private bool BackupFiles(List<SourceFile> files)
    {
        string backFileName = Path.Combine(Config.BackupDir,"CodeGenBackup" + DateTime.UtcNow.AsString(DATETYPE.FileDate) + ".zip");
        using WFZipWriter bf = new WFZipWriter(backFileName);
        ByteArray ba = ByteArray.Rent();
        foreach (var file in files)
        {
            foreach (var gf in file.GeneratedFiles)
            {
                if (File.Exists(gf.FileName))
                {
                    var fi = new FileInfo(gf.FileName);
                    int bytesToRead = (int)fi.Length;
                    ba.Resize(bytesToRead);
                    using (Stream source = File.OpenRead(gf.FileName))
                    {
                        int bytesRead;
                        bytesRead = source.Read(ba.Data, 0, bytesToRead);
                        ba.SetWriteIndex(bytesRead);
                        if (bytesRead != bytesToRead)
                        {
                            LogError($"BackupFiles! {gf.FileName} read {bytesRead} bytes, expected {bytesToRead}");
                            return false;
                        }
                    }
                    if (bf.WriteByteArray(gf.FileName, ba) != WFZipWriter.Status.Ok)
                    {
                        LogError($"BackupFiles! {gf.FileName} failed to write");
                        return false;
                    }
                }
            }
        }
        bf.Close();
        ba.Return();
        return true;

    }
    private void WriteFiles(List<SourceFile> files)
    {
        if (!BackupFiles(files)) return;
        foreach (var file in files)
        {
            foreach(var gf in file.GeneratedFiles) 
            {
                FixNamespace(file);
                Log($"Writing! {gf.FileName}");
                var src = CheckUsings(gf.Source);
                if (gf.FileName.Contains(".def.cs"))
                {
                    ParseDefFile(gf, src);
                    continue;
                }
                File.WriteAllText(gf.FileName, src);
            }
        }
      
    }
    string GetUpdateSrc(string src, out string srcBeforeNamespace)
    {
        var lines = src.Split('\n', StringSplitOptions.None).ToList();
        for(int i=0;i<lines.Count;i++)
        {
            lines[i] = lines[i].TrimEnd(new char[] { '\r', '\n' });
        }
        if (lines[lines.Count - 1] == "") 
            lines.RemoveAt(lines.Count - 1); 
        var sb = StringBuilderPool.Rent();
        var sbBefore = StringBuilderPool.Rent();
        bool foundNamespace = false;
        foreach (var line in lines)
        {
            if (line.StartsWith("namespace"))
            {
                foundNamespace = true;
                sbBefore.AppendLine(line);
                continue;
            }
            if (foundNamespace)
            {
                sb.AppendLine(line);
                continue;
            }
            sbBefore.AppendLine(line);
        }
        var ret = sb.ToString();
        srcBeforeNamespace = sbBefore.ToString();
        StringBuilderPool.Return(sb);
        StringBuilderPool.Return(sbBefore);
        if (foundNamespace) return ret;
        return "";
    }
    void ParseDefFile(SourceFile.GeneratedFile gf, string src)
    {
        src = GetUpdateSrc(src, out string srcBeforeNamespace);
        if (src.Length < 1)
        {
            LogError($"File! {gf.FileName} is missing namespace");
            return;
        }
        var sb = StringBuilderPool.Rent();
        if (!File.Exists(gf.FileName))
        {
            sb.Append(srcBeforeNamespace);
            sb.AppendLine(DONOTEDITSTART);
            sb.Append(src);
            sb.AppendLine(DONOTEDITEND);
            File.WriteAllText(gf.FileName, sb.ToString());
            StringBuilderPool.Return(sb);
            return;
        }
        var oldsrc = File.ReadAllLines(gf.FileName);
        bool foundStart = false;
        bool foundEnd = false;
        foreach (var line in oldsrc)
        {
            if (line.StartsWith(DONOTEDITSTART))
            {
                foundStart = true;
                sb.AppendLine(line);
                sb.Append(src);
                continue;
            }
            if (line.StartsWith(DONOTEDITEND))
            {
                foundEnd = true;
                sb.AppendLine(line);
                continue;
            }
            if (!foundStart)
            {
                sb.AppendLine(line);
                continue;
            }
            if (foundEnd)
            {
                sb.AppendLine(line);
                continue;
            }
        }
        if (!foundStart || !foundEnd)
        {
            LogError($"File! {gf.FileName} is missing {DONOTEDITSTART} or {DONOTEDITEND}");
            return;
        }
        File.WriteAllText(gf.FileName, sb.ToString());
        StringBuilderPool.Return(sb);
    }
    private void FixNamespace(SourceFile sf)
    {
        for (int i = 0; i < sf.GeneratedFiles.Count; i++)
        {
            var file = sf.GeneratedFiles[i];
            file.Source = file.Source.Replace("namespace WFCodeGen;", $"namespace {sf.Namespace};" );
        }
    }
    private string CheckUsings(string src)
    {
        var lines = src.Split("\n");
        var sb = new System.Text.StringBuilder();
        if (!src.Contains("using WFLib;"))
        {
            sb.AppendLine("using WFLib;");
        }
        if (!src.Contains("using Godot;"))
        {
            sb.AppendLine("using Godot;");
        }
        foreach (var l in lines)
        {
            sb.AppendLine(l.TrimEnd());
        }
        var ret = sb.ToString();
        return ret;
    }
}
