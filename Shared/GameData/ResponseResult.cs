namespace Shared.GameData;

public class ResponseResult
{
    public List<Result> Data { get; set; } = new();
    
    public class Result
    {
        public int Code { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> Messages { get; set; }
    }
}