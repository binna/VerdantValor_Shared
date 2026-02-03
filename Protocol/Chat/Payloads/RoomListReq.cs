using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct RoomListReq : IPacketBody
{
    public int RoomCount { get; set; }
    public int[] RoomIds { get; set; }
}