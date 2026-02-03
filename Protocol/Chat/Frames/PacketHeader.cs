using MemoryPack;
using Shared.Types;

namespace Protocol.Chat.Frames;

[MemoryPackable]
public partial struct PacketHeader
{
    public int PayloadSize { get; set; }
    public EPacket PacketType { get; set; }
}