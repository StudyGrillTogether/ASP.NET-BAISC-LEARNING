using DAY_4_PRACTICE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DAY_4_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "shoe", Price = 3000 },
                new Product { Id = 2, Name = "sy Chips",Price=400000 }
            };

            return Ok(products);
        }
        [HttpGet("{Id}")]

        public IActionResult GetProductById(int id)
        {
            var product=new Product { Id = id,Name="shoe",Price=3000 };
            return Ok(product);
        }
    }
}
