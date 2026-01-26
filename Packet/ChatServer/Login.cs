using System.Buffers.Binary;
using System.Text;

namespace VerdantValor_Shared.Packet.ChatServer;

public class Login : IPayload
{
    private const int SESSION_ID_FIELD_SIZE = 36;
    private const int USER_ID_FIELD_SIZE = sizeof(ulong);
    
    public short PayloadSize { get; } = SESSION_ID_FIELD_SIZE + USER_ID_FIELD_SIZE;
    
    public string SessionId { get; set; }
    public ulong UserId { get; set; }

    public void Parse(byte[] buffer)
    {
        SessionId = Encoding.UTF8.GetString(buffer, 0, SESSION_ID_FIELD_SIZE);
        UserId = BinaryPrimitives.ReadUInt64BigEndian(
            buffer.AsSpan(SESSION_ID_FIELD_SIZE, USER_ID_FIELD_SIZE));
    }

    public byte[] From()
    {
        var buffer = new byte[PayloadSize];
        
        Buffer.BlockCopy(
            Encoding.UTF8.GetBytes(SessionId), 0,
            buffer, 0, 
            SESSION_ID_FIELD_SIZE);

        BinaryPrimitives.WriteUInt64BigEndian(
            buffer.AsSpan(SESSION_ID_FIELD_SIZE, USER_ID_FIELD_SIZE), 
            UserId);
        
        return buffer;
    }
}