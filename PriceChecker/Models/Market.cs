namespace PriceChecker.Models
{
    public class Market
    {
        public int MarketId { get; set; }
        public string? MarketName { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
