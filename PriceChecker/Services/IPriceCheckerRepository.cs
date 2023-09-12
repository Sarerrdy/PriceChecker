using PriceChecker.Models;
using System.Diagnostics.Metrics;

namespace PriceChecker.Services
{
    public interface IPriceCheckerRepository
    {
        //Fetch Contact info
        IEnumerable<Country> GetCountryById(int CountryId);
        IEnumerable<State> GetStates(string countryId);
        IEnumerable<LGA> GetLGAs(string stateId);

        //Fetch Products
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int Id);
        // Task<IEnumerable<Product>>  GetProductById(int Id);
        IEnumerable<Product>  GetProductById(int Id);
        IEnumerable<Product> GetProductByCategory(int categoryId);

        //Fetch Histories
        IEnumerable<History> GetHistories(int productId);
    }
}
