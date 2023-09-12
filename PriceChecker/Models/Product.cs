namespace PriceChecker.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? ProductUrl { get; set; }
        public string? Quantity { get; set; }
        public string? Unit { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<Market>? Markets { get; set; }
        public virtual Category? Categories { get; set; }
        public virtual IEnumerable<History>? Histories { get; set; }
        public virtual IEnumerable<Seller>? Sellers { get; set; }

    }
}
