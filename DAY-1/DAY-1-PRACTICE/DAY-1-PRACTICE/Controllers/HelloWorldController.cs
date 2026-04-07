using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_1_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}
