using System.Buffers.Binary;

namespace SharedLibrary.Protocol.Packet.ChatServer;

public class ExitRoomPayload : IPayload
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

        BinaryPrimitives.WriteInt64BigEndian(buffer, RoomId);

        return buffer;
    }
}