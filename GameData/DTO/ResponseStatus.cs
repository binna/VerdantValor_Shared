namespace SharedLibrary.GameData.DTO;

public class ResponseStatusDto
{
    public List<ResponseStatusItemDto> Data { get; set; } = new();
}

public class ResponseStatusItemDto
{
    public int Code { get; set; }
    public bool IsSuccess { get; set; }
    public List<string> Message { get; set; }
}