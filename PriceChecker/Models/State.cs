namespace PriceChecker.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<LGA> LGAs { get; set; }
    }
}
