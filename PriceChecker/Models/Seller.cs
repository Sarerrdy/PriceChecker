namespace PriceChecker.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string? SellerName { get; set; }
        public string? BussinessName { get; set; }
        public string? SellerDescription { get; set; }        
        public int MarketId { get; set; }
        public string? MarketName { get; set; }
        public virtual Contact? contact { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
