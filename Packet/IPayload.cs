namespace SharedLibrary.Protocol.Packet;

public interface IPayload
{
    public short PayloadSize { get; }
    public void Parse(byte[] buffer);
    public byte[] From();
}