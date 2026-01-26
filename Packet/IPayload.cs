namespace VerdantValor_Shared.Packet;

public interface IPayload
{
    short PayloadSize { get; }
    void Parse(byte[] buffer);
    byte[] From();
}