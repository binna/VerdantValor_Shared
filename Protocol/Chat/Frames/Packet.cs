using MemoryPack;
using Shared.Types;

namespace Protocol.Chat.Frames;

public readonly struct Packet<T> where T : struct, IPacketBody
{
    private readonly PacketHeader mHeader;
    private readonly T mPayload;

    public byte[] PacketBytes { get; }

    public Packet(EPacket type, T payload)
    {
        mPayload = payload;
        var payloadBytes = MemoryPackSerializer.Serialize(mPayload);

        mHeader = new PacketHeader
        {
            PayloadSize = payloadBytes.Length,
            PacketType = type
        };
        var headerBytes = MemoryPackSerializer.Serialize(mHeader);

        PacketBytes = new byte[headerBytes.Length + payloadBytes.Length];
        Buffer.BlockCopy(
            headerBytes, 0,
            PacketBytes, 0,
            headerBytes.Length);
        Buffer.BlockCopy(
            payloadBytes, 0,
            PacketBytes, headerBytes.Length,
            payloadBytes.Length);
    }
}