namespace VerdantValor_Shared.Common.ChatServer;

public static class AppEnum
{
    public enum PacketType
    {
        Login = 0,
        CreateRoom = 1,
        DeleteRoom = 2,
        RoomList = 3,
        EnterRoom = 4,
        ExitRoom = 5,
        SendMessage = 6,
        RoomNotification = 7,
        Disconnect = 8
    }
}