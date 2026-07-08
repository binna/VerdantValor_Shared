using MemoryPack;
using Shared.Types;

namespace Protocol.Chat.Payloads;

[MemoryPackable]
public partial struct MessageKind
{
    public long Id { get; set; }
    public MessageType Type { get; set; }
}