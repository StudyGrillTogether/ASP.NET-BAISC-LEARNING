using Microsoft.AspNetCore.Mvc;
using MiniAppMvc.Models;

namespace MiniAppMvc.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products=new List<Product>();
        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) //finds product and shows edit form
            //get is the default when no http atrribute is specified
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product updatedProduct)//updates prodduct after form submit
        {
            var product = products.FirstOrDefault(p => p.Id == updatedProduct.Id);

            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                products.Remove(product);
            }

            return RedirectToAction("Index");
        }
    }
}
