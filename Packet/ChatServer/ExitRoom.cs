namespace VerdantValor_Shared.Packet.ChatServer;

public class ExitRoom : IPayload
{
    public short PayloadSize { get; } = 0;
    
    public void Parse(byte[] buffer)
    { }

    public byte[] From()
    {
        return Array.Empty<byte>();
    }
}