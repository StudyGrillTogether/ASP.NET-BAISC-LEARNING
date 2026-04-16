using Microsoft.AspNetCore.Mvc;
using miniAppAPI.Models;


namespace miniAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController:ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            if(login.Username=="admin"&& login.Password == "123")
            {
                return Ok("Login succesful");
            }

            return Unauthorized("INVALID CREDENTIALS");
        }
    }
}
