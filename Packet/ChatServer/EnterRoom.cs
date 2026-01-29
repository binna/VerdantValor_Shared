using System.Buffers.Binary;

namespace VerdantValorShared.Packet.ChatServer;

public class EnterRoom : IPayload
{
    public short PayloadSize { get; } = sizeof(int);
    
    public int RoomId { get; set; }
    
    public void Parse(byte[] buffer)
    {
        RoomId = BinaryPrimitives.ReadInt32BigEndian(buffer);
    }

    public byte[] From()
    {
        var buffer = new byte[PayloadSize];

        BinaryPrimitives.WriteInt32BigEndian(buffer, RoomId);

        return buffer;
    }
}