using Shared.Types;

namespace Shared.GameData;

public class Store
{
    public int Id { get; set; }
    public Item[] Items { get; set; }
    public Price[] Prices { get; set; }
    public ulong TextId { get; set; }
    public int MaxPurchaseCount { get; set; }       // 0이면 구매 횟수 제한 없음
    
    public class Item
    {
        public int Id { get; set; }
        public int Amount { get; set; }
    }
    
    public class Price
    {
        public ERealCurrency Currency { get; set; }
        public decimal Value { get; set; }
    }
}