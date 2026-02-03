using MemoryPack;
using Protocol.Chat.Frames;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct Login : IPacketBody
{
    public string SessionId { get; set; }
    public ulong UserId { get; set; }
}