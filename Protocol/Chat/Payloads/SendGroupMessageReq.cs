using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct SendGroupMessageReq : IPacketBody
{
    public MessageKind Kind { get; set; }
    public ulong SenderUserId { get; set; }
    public string SenderUserName { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}