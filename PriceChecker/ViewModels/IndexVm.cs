using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Migrations;
using PriceChecker.Models;
using PriceChecker.Services;

namespace PriceChecker.ViewModels
{
    public class IndexVm
    {
        private readonly IPriceCheckerRepository repo;

        public IndexVm(IPriceCheckerRepository repo)
        {
            this.repo = repo;
        }

        public string? ProductName { get; set; }
        public List<int>? Prices { get; set; }
        public List<DateTime>? Dates { get; set; }
        public int? ProductId { get; set; }
        public string? ProductUrl { get; set; }
        public string? Quantity { get; set; }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }


        public List<History>? Histories { get; set; }
        public List<Product>? Products { get; set; }
        public List<Category>? Categories { get; set; }


        ///Populate SelectList for products

        public SelectList? SelectProducts { get; set; }
        public SelectList? SelectCategories { get; set; }
    }
}
