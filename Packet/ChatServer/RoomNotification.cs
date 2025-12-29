using System.Text;

namespace SharedLibrary.Protocol.Packet.ChatServer;

public class RoomNotification : IPayload
{
    public short PayloadSize => (short)Encoding.UTF8.GetByteCount(Notification);

    public string Notification { get; set; } = string.Empty;

    public void Parse(byte[] buffer)
    {
        Notification = Encoding.UTF8.GetString(buffer);
    }

    public byte[] From()
    {
        return Encoding.UTF8.GetBytes(Notification);
    }
}