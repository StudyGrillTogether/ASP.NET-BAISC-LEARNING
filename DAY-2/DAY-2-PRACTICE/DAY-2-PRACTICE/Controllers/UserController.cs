using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_2_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser()
        {
            var user = new
            {
                Name = "Kshitij",
                Email = "kshitij@gmail.com",
                Age = 20
            };

            return Created("/api/user", user);
        }
    }
}
