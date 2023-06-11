namespace WFCodeGen;
/// <summary>
/// The config file for BlazorServer.  This is a partial class that is used to define the data structure.
/// </summary>
public partial class AppConfig : Record
{
[K]  public string ConfigName { get; set; }
     public string Port { get; set; }
     public string GitignoreSourceDir { get; set; }
}