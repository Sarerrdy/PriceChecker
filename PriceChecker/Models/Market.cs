namespace PriceChecker.Models
{
    public class Market
    {
        public int MarketId { get; set; }
        public string? MarketName { get; set; }
        public virtual IEnumerable<Product>? Product { get; set; }
       
        // public int Price { get; set; }
      //  public DateTime Date { get; set; }

    }
}
