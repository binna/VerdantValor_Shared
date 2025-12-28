namespace SharedLibrary.Protocol.Common.Web;

public static class AppEnum
{
    public enum ERankingScope
    {
        My = 1,
        Global = 2
    }

    public enum ERankingType
    {
        All = 1
    }

    public enum EAuthType
    {
        Login = 1,
        Join = 2
    }

    public enum ELanguage
    {
        Ko = 0,
        En = 1,
    }
    
    public enum EResponseStatus
    {
        // 1000 요청 성공
        Success = 1000,
        SuccessEmptyRanking = 1001,
    
        // 그 외의 에러
        EmptyRequiredField = 2000,
        InvalidInput =  2001,
        NoData = 2002,
        FailDecrypt = 2003,
    
        EmailAlphabetNumberOnly = 2010,
        EmailAlreadyExists = 2011,
        NicknameAlreadyExists = 2012,
        InvalidEmailLength = 2013,
        InvalidNicknameLength = 2014,
        ForbiddenEmail = 2015,
        ForbiddenNickname = 2016,
        NotMatchPw  = 2017,
        NicknameAlphabetKoreanNumberOnly = 2018,
    
        ScoreCannotBeNegative = 2020,
    
        // 시스템 에러
        RedisError = 9997,
        DbError = 9998,
        UnexpectedError = 9999,
    }
}