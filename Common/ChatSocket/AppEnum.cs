namespace SharedLibrary.Protocol.Common.ChatSocket;

public class AppEnum
{
    public const int LENGTH_FIELD_SIZE = 2;
    
    public enum PacketType
    {
        Login = 0,
        CreateRoom = 1,
        EnterRoom = 2,
        ExitRoom = 3,
        SendMessage = 4,
        Disconnect = 5
        // TODO 채팅 목록보기
    }
}