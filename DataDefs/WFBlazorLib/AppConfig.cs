namespace WFCodeGen;
/// <summary>
/// The config file for BlazorServer.  This is a partial class that is used to define the data structure.
/// </summary>

public enum SERVERTYPE { LocalServer, WebServer }
public partial class AppConfig : Data
{
    public int    WebServerPort { get; set; }
    public string WebServerAddress { get; set; }
    public int    WebServerTunnelPort { get; set; }
    public int    WebServerLocalPort { get; set; }
    public string LocalServerAddress { get; set; }
    public int    LocalServerPort { get; set; }
    public int    LocalServerTunnelPort { get; set; }
    public string TunnelKeysPassword { get; set; }
    public string GitignoreSourceDir { get; set; }
    public SERVERTYPE ServerType { get; set; }
}
public class AppConfigFile: ConfigFile<AppConfig> 
{ 
    public static AppConfig GetConfig(string key = "Default")
    {
        using var config = new AppConfigFile();
        var d = AppConfig.Util.RentData();
        config.GetConfig(key,d);
        return d;
    }
}