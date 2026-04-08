using DAY_7_PRACTICE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DAY_7_PRACTICE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserInput input)
        {
            ViewBag.SubmittedName = input.Name;
            ViewBag.SubmittedEmail = input.Email;
            return View(input);

        }

        
    }
}
