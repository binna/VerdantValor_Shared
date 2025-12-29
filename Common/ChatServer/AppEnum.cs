namespace SharedLibrary.Protocol.Common.ChatServer;

public static class AppEnum
{
    public enum PacketType
    {
        Login = 0,
        CreateRoom = 1,
        RoomList = 2,
        EnterRoom = 3,
        ExitRoom = 4,
        SendMessage = 5,
        RoomNotification = 6,
        Disconnect = 7
    }
}