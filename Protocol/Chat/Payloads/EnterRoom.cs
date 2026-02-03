using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct EnterRoom : IPacketBody
{
    public int RoomId { get; set; }
}