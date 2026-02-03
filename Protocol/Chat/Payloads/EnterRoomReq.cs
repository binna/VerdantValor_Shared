using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct EnterRoomReq : IPacketBody
{
    public int RoomId { get; set; }
}