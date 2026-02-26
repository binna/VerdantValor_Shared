using Shared.Types;

namespace Shared.GameData;

public class Item
{
    public int ItemId { get; set; }
    public EItemKind ItemKind { get; set; }
    public EPotionType PotionType { get; set; }
    public ulong TextId { get; set; }
    public int Value { get; set; }
    public int Timer { get; set; }
}