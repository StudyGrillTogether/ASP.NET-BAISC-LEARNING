using DAY_13_PRACTICE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace DAY_13_PRACTICE.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult DashBoard()
        {
            ViewBag.Username = User.Identity.Name;
            return View();
        }

        
    }
}
