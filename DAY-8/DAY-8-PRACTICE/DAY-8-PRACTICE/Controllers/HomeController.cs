using DAY_8_PRACTICE.Models;
using DAY_8_PRACTICE.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DAY_8_PRACTICE.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserRepository _repo;

        public HomeController(IConfiguration config)
        {
            _repo = new UserRepository(config.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Index()
        {
            var users = _repo.GetAll();
            return View(users);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            _repo.Insert(user);
            var users=_repo.GetAll();
            return View(users);
        }
    }
}
