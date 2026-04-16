namespace Shared.Types;

public enum EResponseResult
{
    None = 0,
    
    // 1000 요청 성공
    Success = 1000,
    SuccessEmptyRanking = 1001,
    
    // 그 외의 에러
    EmptyRequiredField = 2000,
    InvalidInput =  2001,
    NoData = 2002,
    FailDecrypt = 2003,
    InvalidUserId = 2004,
    LockAcquisitionFailed = 2005,
    
    InvalidEmailFormat = 2010,
    EmailAlreadyExists = 2011,
    NicknameAlreadyExists = 2012,
    InvalidEmailLength = 2013,
    InvalidNicknameLength = 2014,
    ForbiddenEmail = 2015,
    ForbiddenNickname = 2016,
    NotMatchPw  = 2017,
    InvalidNicknameFormat = 2018,
    LoginRequired = 2019,
    InvalidPasswordFormat = 2020,
    
    ScoreCannotBeNegative = 2040,
    
    AlreadyInRoom = 2050,
    AlreadyOutOfRoom = 2051,
    NotInRoom = 2052,
    NoRoomSelected = 2053,
    
    StoreNotFound = 2080,
    PurchaseLimitExceeded = 2081,
    LockReleaseFailed = 2082,
    ItemCreationFailed = 2083,
    PurchaseFailed = 2084,
    
    // 시스템 에러
    RedisError = 9997,
    DbError = 9998,
    UnexpectedError = 9999,
}