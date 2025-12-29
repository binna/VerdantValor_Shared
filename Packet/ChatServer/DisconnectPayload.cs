namespace SharedLibrary.Protocol.Packet.ChatServer;

public class DisconnectPayload : IPayload
{
    public short PayloadSize { get; } = 0;
    
    public void Parse(byte[] buffer)
    { }

    public byte[] From()
    {
        return Array.Empty<byte>();
    }
}