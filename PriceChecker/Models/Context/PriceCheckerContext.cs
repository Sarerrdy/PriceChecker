using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PriceChecker.Models.Context
{
    public class PriceCheckerContext : IdentityDbContext
    {
        public PriceCheckerContext(DbContextOptions<PriceCheckerContext> options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Seller> Sellers { get; set;}
        public DbSet<History> Historys { get; set; }
    }
}
