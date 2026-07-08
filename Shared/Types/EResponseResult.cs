namespace Shared.Types;

public enum EResponseResult
{
    None = 0,
    
    // Success: 1000 ~ 1999
    Success = 1000,
    SuccessEmptyRanking = 1001,
    
    // Common: 2000 ~ 2099
    EmptyRequiredField = 2000,
    InvalidInput =  2001,
    NoData = 2002,
    FailDecrypt = 2003,
    InvalidUserId = 2004,
    LockAcquisitionFailed = 2005,
    
    // Auth: 2110 ~ 2159
    InvalidEmailFormat = 2110,
    EmailAlreadyExists = 2111,
    InvalidEmailLength = 2112,
    InvalidNicknameLength = 2113,
    ForbiddenEmail = 2114,
    ForbiddenNickname = 2115,
    PasswordMismatch  = 2116,
    InvalidNicknameFormat = 2117,
    LoginRequired = 2118,
    InvalidPasswordFormat = 2119,
    InvalidPasswordLength = 2120,
    InvalidAuthType = 2121,
    LoginFailed = 2122,
    
    // Score: 2160 ~ 2179
    ScoreCannotBeNegative = 2160,
    
    // Shop: 2180 ~ 2199
    StoreNotFound = 2180,
    PurchaseLimitExceeded = 2181,
    LockReleaseFailed = 2182,
    ItemCreationFailed = 2183,
    PurchaseFailed = 2184,
    
    // World, Party: 2200 ~ 2399
    AlreadyIn = 2200,
    AlreadyOut = 2201,
    NotIn = 2202,
    NoneSelected = 2203,
    
    // Chat: 2400 ~ 2599
    SendMessageInvalidTarget = 2400,
    
    // System: 9990 ~ 9999
    RedisError = 9997,
    DbError = 9998,
    UnexpectedError = 9999,
}