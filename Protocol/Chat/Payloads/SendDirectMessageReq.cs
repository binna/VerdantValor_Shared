using MemoryPack;
using Protocol.Chat.Frames;
using Shared.Types;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct SendDirectMessageReq : IPacketBody
{
    public long Id { get; set; }
    public MessageType Type { get; set; }
    public ulong SenderUserId { get; set; }
    public string SenderUserName { get; set; }
    public ulong ReceiverUserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}