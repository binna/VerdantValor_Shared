using MemoryPack;
using Shared.Types;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct MessageKind
{
    public string Id { get; set; }
    public MessageCategory Category { get; set; }
    public MessageType Type { get; set; }
}