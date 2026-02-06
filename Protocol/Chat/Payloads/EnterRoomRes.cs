using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct EnterRoomRes : IPacketBody
{
    public int Code { get; set; }
}