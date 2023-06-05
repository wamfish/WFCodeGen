namespace WFCodeGen;
/// <summary>
/// The config file for BlazorServer.  This is a partial class that is used to define the data structure.
/// </summary>

// Note: This probably should not be in WfLib, but until Microsoft Fixes the wonky nature
// of code generation, it is here.


// with a ConfigFile the name of the field should not change
// this differs from a Record in that the field position
// should not change
public partial class BlazorServerData : Data
{
    public string HttpAddress { get; set; } = "";
    public string HttpsAddress { get; set; } = "";
    public string ServerDataDir { get; set; } = "";

    public static BlazorServerData Load(string key)
    {
        if (configFile == null) configFile = new BlazorServerConfig();
        var config = configFile.RentData();
        configFile.GetConfig(key, config);
        //configFile.UpdateConfig(key, config);
        return config;
    }
    static BlazorServerConfig configFile;


}
class BlazorServerConfig : ConfigFile<BlazorServerData>
{
    public static BlazorServerConfig File = new();
    public static BlazorServerData Load(string key)
    {
        var config = File.RentData();
        File.GetConfig(key, config);
        return config;
    }
    public BlazorServerConfig()
    {
    }
}