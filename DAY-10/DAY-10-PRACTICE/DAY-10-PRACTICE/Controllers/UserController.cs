using DAY_10_PRACTICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAY_10_PRACTICE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "Kshitij", Email = "k@gmail.com" },
            new User { Id = 2, Name = "Solace", Email = "sol@gmail.com" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _users.Add(user);
            return Created("", user);
        }
    }
}