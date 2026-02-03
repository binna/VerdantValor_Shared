using Shared.Types;

namespace Protocol.Web.Dtos;

public class AuthReq
{
    // TODO profbuf로 바꾸면서 nullable 정리하기
    public string AuthType { get; set; }
    public string? Nickname { get; set; }
    public string Email { get; set; }
    public string Pw { get; set; }
    public string Language { get; set; } = $"{ELanguage.En}";
}