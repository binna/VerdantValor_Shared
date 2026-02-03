using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct RoomNotificationReq : IPacketBody
{
    public string Notification { get; set; }
}