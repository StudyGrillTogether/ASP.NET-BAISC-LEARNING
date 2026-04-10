using DAY_9_PRACTICE.Models;
using Microsoft.AspNetCore.Mvc;
using DAY_9_PRACTICE.Repositories;

namespace DAY_9_PRACTICE.Controllers
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
            return RedirectToAction("Index");
        }
        
        //EDIT-LOAD USER INT THE FORM
        public IActionResult Edit(int id)
        {
            var user=_repo.GetById(id);
            return View(user);
        }

        //EDIT -SAVE UPDATED USER
        [HttpPost]
        public IActionResult Edit(User user)
        {
            _repo.Update(user);
            return RedirectToAction("Index");
        }

        //DELETE
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
