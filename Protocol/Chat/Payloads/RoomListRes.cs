using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct RoomListRes : IPacketBody, IResponsePacket
{
    public int Code { get; set; }
    public int RoomCount { get; set; }
    public int[] RoomIds { get; set; }
}