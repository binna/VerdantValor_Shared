using System.Text;

namespace VerdantValor_Shared.Packet.ChatServer;

public class SendMessage : IPayload
{
    public short PayloadSize => (short)Encoding.UTF8.GetByteCount(Message);

    public string Message { get; set; } = string.Empty;

    public void Parse(byte[] buffer)
    {
        Message = Encoding.UTF8.GetString(buffer);
    }

    public byte[] From()
    {
        return Encoding.UTF8.GetBytes(Message);
    }
}