namespace Shared.Types;

public enum EPacket
{
    Login = 0,
    EnterWorld = 1,
    EnterParty = 2,
    ExitWorld = 3,
    ExitParty = 4,
    SendMessage = 5,
    Notification = 6,
    Disconnect = 7,         // 로그아웃 개념도 같이 가져감
}