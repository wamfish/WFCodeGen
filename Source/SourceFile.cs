using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WFCodeGen;

public class SourceFile
{
    public string FileName { get; init; }
    public string Source = "";
    public string Namespace = "";
    public SourceFile(string fileName, string sourceCode, string nameSpace)
    {
        FileName = fileName;
        Source = sourceCode;
        Namespace = nameSpace;
    }
    public bool HasGenerationTarget =>  GeneratedFiles.Count > 0;
    public readonly List<string> Errors = new();
    public bool HasError => Errors.Count > 0;
    public readonly List<GeneratedFile> GeneratedFiles = new();
    public void AddGeneratedFile(string fileName, string source, ClassDeclarationSyntax cds, Data data)
    {
        GeneratedFiles.Add(new GeneratedFile(fileName, source, cds, data));
    }
    public class GeneratedFile
    {
        public string FileName { get; init; }
        public string Source;
        public ClassDeclarationSyntax Cds { get; init; }
        public Data Data { get; init; }
        public string ClassName => Cds.Identifier.ValueText;
        public GeneratedFile(string fileName, string source, ClassDeclarationSyntax cds, Data data)
        {
            FileName = fileName;
            Source = source;
            Cds = cds;
            Data = data;
        }
    }
}
