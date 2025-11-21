using SharedLibrary.Protocol.Common.ChatSocket;

namespace SharedLibrary.Protocol.DTOs.ChatSocket;

public class MessageHeader
{
    public AppEnum.PacketType Type { get; set; }
    public int Length { get; set; }
}