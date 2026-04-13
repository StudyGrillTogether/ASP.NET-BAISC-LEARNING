using DAY_11_PRACTICE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DAY_11_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> _users = new List<User>()
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
            var user = _users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();

            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _users.Add(user);
            return Created("", user);
        }

        //search-query parameter
        [HttpGet("search")]
        public IActionResult Search(string name)
        {
            var result = _users.Where(u => u.Name.Contains(name)).ToList();
            return Ok(result);
        }
        //Update
        [HttpPut("{id}")]
        public IActionResult Update(int id, User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            return Ok(user);
        }

        //DELETE
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var user=_users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            _users.Remove(user);
            return Ok("User deleted successfully");
        }
    }
}
