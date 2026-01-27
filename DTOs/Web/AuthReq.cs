using VerdantValorShared.Common.Web;

namespace VerdantValorShared.DTOs.Web;

public class AuthReq
{
    public string AuthType { get; set; }
    public string? Nickname { get; set; }
    public string Email { get; set; }
    public string Pw { get; set; }
    public string Language { get; set; } = $"{AppEnum.ELanguage.En}";
}