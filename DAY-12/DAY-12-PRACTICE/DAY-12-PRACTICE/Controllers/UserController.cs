using DAY_12_PRACTICE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_12_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "Kshitij", Email = "k@gmail.com" },
            new User { Id = 2, Name = "Solace", Email = "sol@gmail.com" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_users);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "something went wrong with the server"+ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = _users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    return NotFound("User not found");
                }
                return Ok(user);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Something went Wrong: " + ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            try
            {
                if (_users.Any(u => u.Email == user.Email))
                {
                    return BadRequest("A user with this email already exists");
                }
                _users.Add(user);
                return Created("", user);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Something went wrong: " + ex.Message);
            }
        }
    }
}
