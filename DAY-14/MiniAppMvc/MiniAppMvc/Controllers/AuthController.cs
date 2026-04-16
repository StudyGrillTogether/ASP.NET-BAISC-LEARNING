using Microsoft.AspNetCore.Mvc;
using MiniAppMvc.Models;

namespace MiniAppMvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            if (login.Username == "admin" && login.Password == "123")
            {
                return RedirectToAction("Index","Product");
            }

            ViewBag.Message = "Invalid Credentials";
            return View();
        }
    }
}
