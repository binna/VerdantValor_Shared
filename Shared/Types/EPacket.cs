namespace Shared.Types;

public enum EPacket
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