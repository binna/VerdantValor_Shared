using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable ]
public partial struct SendMessageRes : IPacketBody
{
    public int Code { get; set; }
    public ulong userId { get; set; }
    public string Message { get; set; }
}