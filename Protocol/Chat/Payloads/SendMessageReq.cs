using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct SendMessageReq : IPacketBody
{
    public string Message { get; set; }
}