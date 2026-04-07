using DAY_6_PRACTICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAY_6_PRACTICE.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 75000, Description = "Gaming laptop" },
                new Product { Id = 2, Name = "Phone", Price = 25000, Description = "Android phone" },
                new Product { Id = 3, Name = "Tablet", Price = 35000, Description = "iPad alternative" }
            };
            return View(products);
        }
    }
}
