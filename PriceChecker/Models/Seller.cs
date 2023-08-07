namespace PriceChecker.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string? SellerName { get; set; }
        public string? SellerDescription { get; set; }
        public int MarketId { get;}
        public string? MarketName { get; set; }
        public virtual Contact? contact { get; set; }
    }
}
