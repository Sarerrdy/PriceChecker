using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PriceChecker.Models;
using PriceChecker.Services;
using PriceChecker.ViewModels;
using System.Text.Json;

namespace PriceChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsApiController : ControllerBase
    {
        private readonly IPriceCheckerRepository _repo;
        public ChartsApiController(IPriceCheckerRepository repo)
        {
            _repo = repo;               
        }
        [Route("{LoadHistories}/{productId}/{CategoryId}")]
        [HttpGet]
        public IndexVm LoadHistories(int productId, int CategoryId)
        {            
            var result = _repo.GetHistories(productId);
            var vm = new IndexVm(_repo);
            vm.Histories = new List<History>();

            if (result != null)
            {
                foreach (var p in result)
                {
                    var newPrice = new History()
                    {
                        Prices = p.Prices,
                        DateAdded = p.DateAdded,
                        ProductId = p.ProductId,
                        HistoryId = p.HistoryId
                    };

                    vm.Histories.Add(newPrice);
                }
            }
            vm.Prices = vm.Histories.Select(x => x.Prices).ToList();
            vm.Dates = vm.Histories.Select(x => x.DateAdded).ToList();
            //var serializeResult = JsonSerializer.Serialize(prodPriceHistory);

            return vm;

        }

        [Route("{GetSelectListProduct}/{categoryId}")]
        [HttpGet]
        public SelectList GetSelectListProduct(string categoryId)
        {
            if (!string.IsNullOrWhiteSpace(categoryId))
            {
                var products = new SelectList(_repo.GetProductByCategory(int.Parse(categoryId)), nameof(Product.ProductId), nameof(Product.Name));

                return products;
            }
            return null;
        }
    }
}
