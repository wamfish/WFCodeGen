namespace WFCodeGen;
public static class Config
{
    public static readonly string LocalGenDir = "C:\\prog\\Wamfish\\WFCodeGen\\Generated\\WFCodeGenLib\\WFCodeGenLib.IncDataGen\\";
    public static readonly string WFCodeGenDir = "C:\\prog\\Wamfish\\WFCodeGen\\";
    public static string DataDefsDir
    {
        get
        {
            return Path.Combine(WFCodeGenDir, "DataDefs");
        }
    }
    public static string MainDir
    {
        get
        {
            string path = Path.Combine(WFCodeGenDir, "X");
            path = Path.GetDirectoryName(path);
            path = Path.GetDirectoryName(path);
            return path;
        }
    }
    public static string BackupDir
    {
        get
        {
            string path = Path.Combine(MainDir, "Backups");
            return path;
        }
    }
    public static readonly List<ICodeGenerator> OtherGenerators = new()
    {
        new CGBlazor(),
    };
}