using Shared.Types;

namespace Shared.Constants;

public static class AppConstant
{
    // TODO 여기서 클라이언트 공유할 수 있는 상수는 따로 빼기
    
    public const string WEB_SERVER_API_BASE = "api";
    public const string RANKING_ROOT = "Ranking";

    public const int EAMIL_MIN_LENGTH = 5;
    public const int EAMIL_MAX_LENGTH = 50;

    public const int NICKNAME_MIN_LENGTH = 3;
    public const int NICKNAME_MAX_LENGTH = 30;
    
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 64;

    public const int RANKING_MIN = 50;
    public const int RANKING_MAX = 100;

    public const int HEADER_SIZE = sizeof(int) + sizeof(EPacket) + sizeof(int);
}