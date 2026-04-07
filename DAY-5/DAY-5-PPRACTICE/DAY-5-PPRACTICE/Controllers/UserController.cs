using DAY_5_PPRACTICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAY_5_PPRACTICE.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new User
            {
                Id = 1,
                Name = "Kshitij",
                Email = "kshitij@gmail.com",
                Age = 20,
                Address = "Mumbai",
                Phone = "9999999999"
            };
            return View(user);
        }
    }
}
