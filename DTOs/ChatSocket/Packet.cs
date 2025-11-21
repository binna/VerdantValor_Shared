namespace SharedLibrary.Protocol.DTOs.ChatSocket;

public class Packet<T>
{
    public MessageHeader Header { get; set; }
    public T Body { get; set; }
}