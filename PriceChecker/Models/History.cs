namespace PriceChecker.Models
{
    public class History
    {
        public int HistoryId { get; set; }
        public int Prices { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
