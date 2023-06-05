using System.Security.Cryptography;

namespace WFCodeGen;
public partial class LoginFormData : Data
{
    public LoginFormData() 
    {
        VFRequired(FID.Nickname);
        VFPassword(FID.Password);
        VFConfirmPassword(FID.ConfirmPassword, FID.Password);
    }
    public string UserGUID { get; set; }
    public string Nickname { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}

