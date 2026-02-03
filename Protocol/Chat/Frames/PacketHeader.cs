using MemoryPack;
using Shared.Types;

namespace Protocol.Chat.Frames;

[MemoryPackable]
public partial struct PacketHeader
{
    // [필수]
    //  항목이 추가된다면 AppConstant.HEADER_SIZE에도 반영하기
    public int PayloadSize { get; set; }
    public EPacket PacketType { get; set; }
}