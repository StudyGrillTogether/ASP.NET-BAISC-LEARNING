using Microsoft.AspNetCore.Mvc;
using miniAppAPI.Models;

namespace miniAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private static List<Product> products = new List<Product>();
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(products);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return Ok("Product Added");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id,Product updateProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound("Product not found");
            }

            product.Name = updateProduct.Name;
            product.Price = updateProduct.Price;

            return Ok("product updated");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound("Product Not Found");
            }

            products.Remove(product);

            return Ok("Product Deleted");
        }
    }
}
