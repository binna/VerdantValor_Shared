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
    InvalidEmailLength = 2012,
    InvalidNicknameLength = 2013,
    ForbiddenEmail = 2014,
    ForbiddenNickname = 2015,
    NotMatchPw  = 2016,
    InvalidNicknameFormat = 2017,
    LoginRequired = 2018,
    InvalidPasswordFormat = 2019,
    InvalidPasswordLength = 2020,
    InvalidAuthType = 2021,
    
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