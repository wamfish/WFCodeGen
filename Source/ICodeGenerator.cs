namespace WFCodeGen;
public interface ICodeGenerator
{
    public SourceFile Run(Data data, string Namespace);
}
