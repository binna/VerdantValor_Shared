using MemoryPack;
using Protocol.Chat.Frames;
using Shared.Types;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct SendGroupMessageReq : IPacketBody
{
    public long Id { get; set; }
    public MessageType Type { get; set; }
    public ulong SenderUserId { get; set; }
    public string SenderUserName { get; set; }
    public string GroupName { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}