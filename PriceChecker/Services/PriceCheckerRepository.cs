using Microsoft.EntityFrameworkCore;
using PriceChecker.Models;
using PriceChecker.Models.Context;

namespace PriceChecker.Services
{
    public class PriceCheckerRepository : IPriceCheckerRepository
    {
        private readonly PriceCheckerContext _ctx;

        ///Constructor
        public PriceCheckerRepository(PriceCheckerContext ctx)
        {
               _ctx = ctx;
        }


        ///Fetch Contact info 
        IEnumerable<Country> IPriceCheckerRepository.GetCountryById(int CountryId)
        {
            return _ctx.Countries
               .Where(s => s.CountryId == CountryId)
               .Include(s => s.States)
               .ThenInclude(s => s.LGAs)
               .ToList();
        }
        IEnumerable<LGA> IPriceCheckerRepository.GetLGAs(string stateId)
        {

            if (!string.IsNullOrWhiteSpace(stateId))
            {
                //using (var context = new ApplicationDbContext())
                //{
                IEnumerable<LGA> lgas = _ctx.LGAs.AsNoTracking()
                    .OrderBy(n => n.LGAName)
                    .Where(n => n.StateId == int.Parse(stateId))
                    .Select(n =>
                       new LGA
                       {
                           LGAId = n.LGAId,
                           LGAName = n.LGAName
                       }).ToList();
                return lgas;
            }
            return null;
        }
        IEnumerable<State> IPriceCheckerRepository.GetStates(string countryId)
        {
            if (!string.IsNullOrWhiteSpace(countryId))
            {
                IEnumerable<State> states = _ctx.States.AsNoTracking()
                    .OrderBy(n => n.StateName)
                    .Where(n => n.CountryId == int.Parse(countryId))
                    .Select(n =>
                       new State
                       {
                           StateId = n.StateId,
                           StateName = n.StateName
                       }).ToList();

                return states;
            }
            return null;
        }



        ///Fetch Product Categories
        public IEnumerable<Category> GetCategories()
        {
            return _ctx.Categories
                        .ToList();
        }
        public Category GetCategoryById(int Id)
        {
            return _ctx.Categories
               .Single(s => s.Id == Id);
        }

       
        ///Get Product
        public IEnumerable<Product> GetProductByCategory(int categoryId)
        {
            return _ctx.Products
                 .Where(s => s.CategoryId == categoryId)
                 //.Include(r => r.Histories)
                 //.Include(p => p.Sellers)
                 //.Include(q => q.Markets)
                 //.Include(s => s.Categories)
                 .Select(x =>
                     new Product
                     {
                         ProductId = x.ProductId,
                         Name = x.Name
                     }).ToList();
        }       

        public IEnumerable<Product> GetProductById(int Id)
        {
            return _ctx.Products
                 .Where(s => s.ProductId == Id)
                 .Include(r => r.Histories.Where(x => x.ProductId == Id))
                 .Include(p => p.Sellers)
                 .Include(q => q.Markets)
                 .Include(s => s.Categories)
                .ToList();
        }




        ///Fetch Histories
        public IEnumerable<History> GetHistories(int productId)
        {
            return _ctx.Historys
               .Where(s => s.ProductId == productId)
               .ToList();
        }
    }
}
