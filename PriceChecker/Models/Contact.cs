namespace PriceChecker.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? Landmarks { get; set; }
        public string? LGA { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
