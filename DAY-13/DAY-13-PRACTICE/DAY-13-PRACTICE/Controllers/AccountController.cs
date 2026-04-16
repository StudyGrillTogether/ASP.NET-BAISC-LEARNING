using DAY_13_PRACTICE.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DAY_13_PRACTICE.Controllers
{
    public class AccountController : Controller
    {
        private const string HardcodedUsername = "admin";
        private const string HardcodedPassword = "password123";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if(model.Username==HardcodedUsername&& model.Password == HardcodedPassword)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,model.Username)
                };
                var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var principal=new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

                return RedirectToAction("DashBoard", "Home");
            }
            ModelState.AddModelError("", "Invalid username or password");

            return View(model);  
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
