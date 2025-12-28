namespace SharedLibrary.Protocol.GameData;

public class ResponseStatus
{
    public List<ResponseStatusItem> Data { get; set; } = new();
}

public class ResponseStatusItem
{
    public int Code { get; set; }
    public bool IsSuccess { get; set; }
    public List<string> Message { get; set; }
}