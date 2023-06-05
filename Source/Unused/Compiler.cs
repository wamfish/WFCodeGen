using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace WFCodeGen;
public class Compiler
{
    private PortableExecutableReference GetReference(Type fromType)
    {
        var al = fromType.Assembly.Location;
        var per = PortableExecutableReference.CreateFromFile(al);
        return per;
    }
    /// <summary>
    /// Compile does not output any dll. I am only using it to test the compilation 
    /// of the generated code. We need to make sure that the generated code is valid
    /// before outputting it to a file.
    /// </summary>
    /// <param name="strees"></param>
    /// <returns></returns>
    public bool Compile(SourceConfig sc, bool printError = false)
    {
        MemoryStream ms = new MemoryStream();
        List<PortableExecutableReference> refs = new List<PortableExecutableReference>();
        refs.Add(Basic.Reference.Assemblies.Net70.References.System);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemRuntime);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemConsole);
        refs.Add(Basic.Reference.Assemblies.Net70.References.netstandard);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemCollections);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemThreading);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemNumerics);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemNumericsVectors);
        refs.Add(Basic.Reference.Assemblies.Net70.References.SystemBuffers);
        refs.Add(GetReference(typeof(WFLib.Global)));
        sc.AddReferences?.Invoke(refs);
        var c = CSharpCompilation.Create("CompileTest");
        var copt = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, platform: Platform.AnyCpu);
        c = c.WithOptions(copt);
        c = c.WithReferences(refs);
        foreach (var file in sc.Files)
        {
            if (file.HasError) continue;
            if (file.HasGenerationTarget)
            {
                //c = c.AddSyntaxTrees(file.CdsList[0].SyntaxTree);
            }
        }
        var r = c.Emit(ms);
        if (r.Success)
        {
            ClassInfo.KAttribute = c.GetTypeByMetadataName("WFLib.KAttribute");
            ClassInfo.XAttribute = c.GetTypeByMetadataName("WFLib.XAttribute");
            ClassInfo.RangeAttribute = c.GetTypeByMetadataName("WFLib.RangeAttribute");
            foreach (var file in sc.Files)
            {
                if (file.HasError)
                {
                    foreach (var error in file.Errors)
                    {
                        LogWarning("  " + error);
                    }
                    continue;
                }
                if (file.HasGenerationTarget)
                {
                    //file.GeneratedSource.Clear();
                    //file.GeneratedFileName.Clear();
                    //foreach(var cds in file.CdsList)
                    //{
                    //    ClassInfo ci = new ClassInfo(c, cds);
                    //    ci.SourceFilePath = file.FileName;
                    //    for(int i=0;i<sc.CodeGenerators.Count;i++)
                    //    {
                    //        var codegen = sc.CodeGenerators[i];
                    //        var cw  = sc.CodeGenerators[i].Run(ci);
                    //        if (cw != null)
                    //        {
                    //            file.GeneratedSource.Add(cw.ToString());
                    //            file.UpdateGeneratedFileName(ci.Name,codegen.GeneratedExtension,codegen.GeneratedOutputPath);
                    //        }
                    //    }
                    //    Log($"Generated code for! {ci.Name}:");
                    //}
                }
            }
            return true;
        }
            
        var d = r.Diagnostics;
        if (printError)
        {
            foreach (var diag in d)
            {
                LogError($"Compile Error: {diag}");
            }
        }
        return false;
    }
}
