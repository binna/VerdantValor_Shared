namespace VerdantValor_Shared.DTOs.Web;

public class EncryptReq
{
    public string Nonce { get; set; }
    public string Tag { get; set; }
    public string Data { get; set; }
}