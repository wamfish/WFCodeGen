using Microsoft.CodeAnalysis;

namespace WFCodeGen;

public class SourceConfig
{
    public string Name { get; init; }
    public string Namespace { get; init; }
    public string SourceDir { get; init; }
    public bool Enabled { get; set; } = true;
    public readonly List<SourceFile> Files = new();
    public List<string> Usings { get; init; }
    public Action<List<PortableExecutableReference>> AddReferences { get; init; } = null;
    public List<ICodeGenerator> CodeGenerators { get; init; }
}
