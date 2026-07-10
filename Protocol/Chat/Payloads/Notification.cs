using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct Notification : IPacketBody
{
    public MessageKind Kind { get; set; }
    public string Content { get; set; }
}