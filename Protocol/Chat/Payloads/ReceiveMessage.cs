using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct ReceiveMessage : IPacketBody, IResponsePacket
{
    public int Code { get; set; }
}