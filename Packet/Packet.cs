namespace SharedLibrary.Protocol.Packet;

public class Packet<T> where T : IPayload
{
    public Header PacketHeader { get; set; }
    public T PacketPayload { get; set; }

    public Packet(Header header, T payload)
    {
        PacketHeader = header;
        PacketPayload = payload;
    }

    public byte[] From()
    {
        var header = PacketHeader.From();
        var payload = PacketPayload.From();
        
        var buffer = new byte[Header.HEADER_SIZE + PacketPayload.PayloadSize];
        
        Buffer.BlockCopy(
            header, 0,
            buffer, 0, 
            Header.HEADER_SIZE);
        
        Buffer.BlockCopy(
            payload, 0,
            buffer, Header.HEADER_SIZE, 
            PacketPayload.PayloadSize);
        
        return buffer;
    }
}