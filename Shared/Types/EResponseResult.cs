namespace Shared.Types;

public enum EResponseResult
{
    None = 0,
    
    // Success: 1000 ~ 1999
    Success = 1000,
    SuccessEmptyRanking = 1001,
    
    // Common: 2000 ~ 2009
    EmptyRequiredField = 2000,
    InvalidInput =  2001,
    NoData = 2002,
    FailDecrypt = 2003,
    InvalidUserId = 2004,
    LockAcquisitionFailed = 2005,
    
    // Auth: 2010 ~ 2039
    InvalidEmailFormat = 2010,
    EmailAlreadyExists = 2011,
    InvalidEmailLength = 2012,
    InvalidNicknameLength = 2013,
    ForbiddenEmail = 2014,
    ForbiddenNickname = 2015,
    PasswordMismatch  = 2016,
    InvalidNicknameFormat = 2017,
    LoginRequired = 2018,
    InvalidPasswordFormat = 2019,
    InvalidPasswordLength = 2020,
    InvalidAuthType = 2021,
    LoginFailed = 2022,
    
    // Score: 2040 ~ 2049
    ScoreCannotBeNegative = 2040,
    
    // Shop: 2080 ~ 2089
    StoreNotFound = 2080,
    PurchaseLimitExceeded = 2081,
    LockReleaseFailed = 2082,
    ItemCreationFailed = 2083,
    PurchaseFailed = 2084,
    
    // World, Room: 2050 ~ 2059
    AlreadyIn = 2050,
    AlreadyOut = 2051,
    NoneSelected = 2052,
    
    // Chat: 2100 ~ 2199
    SendMessageInvalidTarget = 2100,
    
    // System: 9990~9999
    RedisError = 9997,
    DbError = 9998,
    UnexpectedError = 9999,
}