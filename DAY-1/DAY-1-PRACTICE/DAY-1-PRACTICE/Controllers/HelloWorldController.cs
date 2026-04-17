using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_1_PRACTICE.Controllers
{
    [Route("api/[controller]")] //this is the route template
    //it tells the application that this controller will handle requests that start with "api/HelloWorld"
    [ApiController] //this is an attribute that tells the application that this class is a controller
    public class HelloWorldController : ControllerBase
    {
        [HttpGet] //this is an attribute that tells the application that this method will handle GET requests
        public IActionResult Get()
        //this is a method that will handle GET requests
        //it returns an IActionResult which is an interface that represents the result of an action method
            return Ok("hello world");//respinse is sent to to the browser or swagger and output is displayed
        }
    }
}
//User hits /api/HelloWorld
//↓
//Request goes to app
//↓
//app.MapControllers() routes it
//↓
//HelloWorldController is found
//↓
//Get() method is called
//↓
//"Hello World" returned
//↓
//Browser shows response