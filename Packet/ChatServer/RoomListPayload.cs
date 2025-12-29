using System.Buffers.Binary;

namespace SharedLibrary.Protocol.Packet.ChatServer;

public class RoomListPayload : IPayload
{
    public short PayloadSize => (short)(RoomCount * sizeof(int));

    public int RoomCount { get; set; }
    public int[] RoomIds { get; set; } = Array.Empty<int>();

    public void Parse(byte[] buffer)
    {
        RoomCount = BinaryPrimitives.ReadInt32BigEndian(buffer);
        
        RoomIds = new int[RoomCount];
        var offset = 0;
        
        for (var i = 0; i < RoomCount; i++)
        {
            RoomIds[i] = BinaryPrimitives.ReadInt32BigEndian(
                buffer.AsSpan(offset, sizeof(int)));
            
            offset += sizeof(int);
        }
    }

    public byte[] From()
    {
        var buffer = new byte[RoomCount * sizeof(int)];
        var offset = 0;
        
        BinaryPrimitives.WriteInt32BigEndian(buffer, RoomCount);
        
        foreach (var roomId in RoomIds)
        {
            BinaryPrimitives.WriteInt32BigEndian(
                buffer.AsSpan(offset, sizeof(int)),
                roomId
            );

            offset += sizeof(int);
        }
        
        return buffer;
    }
}