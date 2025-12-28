using System.Text;

namespace SharedLibrary.Protocol.Packet.ChatServer;

public class SendMessagePayload : IPayload
{
    public short PayloadSize
        => (short)Encoding.UTF8.GetByteCount(Message ?? string.Empty);
    
    public string Message { get; set; }

    public void Parse(byte[] buffer)
    {
        Message = Encoding.UTF8.GetString(buffer);
    }

    public byte[] From()
    {
        return Encoding.UTF8.GetBytes(Message);
    }
}