using System.Buffers.Binary;

namespace VerdantValor_Shared.Packet;

public class Header
{
    public const int HEADER_SIZE = LENGTH_FIELD_SIZE + TYPE_FIELD_SIZE;
    
    private const int LENGTH_FIELD_SIZE = sizeof(short);
    private const int TYPE_FIELD_SIZE = sizeof(int);
    
    public short PayloadLength { get; set; }
    public int Type { get; set; }

    public void Parse(byte[] buffer)
    {
        PayloadLength = BinaryPrimitives.ReadInt16BigEndian(buffer);
        Type = BinaryPrimitives.ReadInt32BigEndian(
            buffer.AsSpan(LENGTH_FIELD_SIZE, TYPE_FIELD_SIZE));
    }
    
    public byte[] From()
    {
        var buffer = new byte[HEADER_SIZE];

        BinaryPrimitives.WriteInt16BigEndian(
            buffer.AsSpan(0, LENGTH_FIELD_SIZE), PayloadLength);
        
        BinaryPrimitives.WriteInt32BigEndian(
            buffer.AsSpan(LENGTH_FIELD_SIZE, TYPE_FIELD_SIZE), Type);
        
        return buffer;
    }
}