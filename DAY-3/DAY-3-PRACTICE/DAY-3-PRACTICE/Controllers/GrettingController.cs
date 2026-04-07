using DAY_3_PRACTICE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_3_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly GreetingService _greetingService;

        public GreetingController(GreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_greetingService.Greet("Kshitij"));
        }
    }
}
