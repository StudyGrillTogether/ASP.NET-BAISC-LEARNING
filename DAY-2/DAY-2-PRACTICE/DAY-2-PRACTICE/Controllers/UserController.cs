using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_2_PRACTICE.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    //Adds API-specific behavior:
    //Automatic model validation
    //Better error responses
    //Simplifies request handling
    //Makes your controller behave like a proper Web API.
    public class UserController : ControllerBase
    //Defines a controller class
    //Inherits from ControllerBase
    //Why ControllerBase:
    //Used for APIs (no views)
    //Gives methods like:
    //Ok()
    //Created()
    //BadRequest()
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
            //Created() is used when a new resource is successfully created. 
            //It returns status code 201 Created and optionally includes the location of the created resource.
        }
    }
}
