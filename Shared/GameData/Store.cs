using Shared.Types;

namespace Shared.GameData;

public class Store
{
    public int StoreId { get; set; }
    public Item[] Items { get; set; }
    public Price[] Prices { get; set; }
    public ulong TextId { get; set; }
    public int MaxPurchaseCount { get; set; }
    
    public class Item
    {
        public int ItemId { get; set; }
        public int Amount { get; set; }
    }
    
    public class Price
    {
        public ERealCurrency Currency { get; set; }
        public decimal Value { get; set; }
    }
}