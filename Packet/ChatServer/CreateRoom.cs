namespace VerdantValor_Shared.Packet.ChatServer;

public class CreateRoom : IPayload
{
    public short PayloadSize { get; } = 0;

    public void Parse(byte[] buffer)
    { }

    public byte[] From()
    {
        return Array.Empty<byte>();
    }
}