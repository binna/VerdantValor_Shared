namespace SharedLibrary.Protocol.Common.ChatSocket;

public class AppEnum
{
    public enum PacketType
    {
        Login,
        EnterRoom,
        ExitRoom,
        ChatMessage,
        ChatBroadcast
    }
}