using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct DisconnectRes : IPacketBody, IResponsePacket
{
    public int Code { get; set; }
}