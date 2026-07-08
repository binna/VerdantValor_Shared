using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct EnterWorldReq : IPacketBody
{
    public string worldName { get; set; }
}