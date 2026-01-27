using VerdantValorShared.Common.ChatServer;

namespace VerdantValorShared.Packet;

public class Packet<T> where T : class, IPayload
{
    private Header mHeader;
    private T mPayload;

    public Packet(T payload)
    {
        var className = typeof(T).Name;
        if (!Enum.TryParse<AppEnum.PacketType>(className, out var packetType))
        {
            throw new ArgumentException(
                $"Unsupported packet payload type: {className}",
                nameof(payload));
        }

        mPayload = payload;
        mHeader = new Header
        {
            PayloadLength = payload.PayloadSize,
            Type = (int)packetType
        };
    }
    
    public Packet(Header header, T payload)
    {
        mHeader = header;
        mPayload = payload;
    }

    public byte[] From()
    {
        var header = mHeader.From();
        var payload = mPayload.From();
        
        var buffer = new byte[Header.HEADER_SIZE + mPayload.PayloadSize];
        
        Buffer.BlockCopy(
            header, 0,
            buffer, 0, 
            Header.HEADER_SIZE);
        
        Buffer.BlockCopy(
            payload, 0,
            buffer, Header.HEADER_SIZE, 
            mPayload.PayloadSize);
        
        return buffer;
    }
}