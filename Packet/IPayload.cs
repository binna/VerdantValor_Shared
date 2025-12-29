namespace SharedLibrary.Protocol.Packet;

public interface IPayload
{
    short PayloadSize { get; }
    void Parse(byte[] buffer);
    byte[] From();
}