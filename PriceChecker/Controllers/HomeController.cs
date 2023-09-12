using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using PriceChecker.Models;
using PriceChecker.Services;
using PriceChecker.ViewModels;

namespace PriceChecker.Controllers
{
    public class HomeController : Controller
    {
        private IPriceCheckerRepository _repo;

        public HomeController(IPriceCheckerRepository rep)
        {
            _repo = rep;
        }
        public IActionResult Index()
        {
            var product = _repo.GetProductByCategory(1);
            var vm = new IndexVm(_repo)
            {
                //Populating the selected List Items
                SelectCategories = new SelectList(_repo.GetCategories(), nameof(Category.Id), nameof(Category.Name)),
                SelectProducts = new SelectList(product, nameof(Product.ProductId), nameof(Product.Name))
            };

            //set the default selectList values
            vm.SelectCategories.ElementAt(0).Selected = true;
            vm.SelectProducts.ElementAt(0).Selected = true;

            return View(vm);
        }
    }
}
