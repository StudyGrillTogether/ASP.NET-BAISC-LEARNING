using DAY_4_PRACTICE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DAY_4_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //get api/student
        [HttpGet]
        public IActionResult GetStudent()
        {
            var Students = new List<Student>
            {
                new Student{Id = 1,
                Name = "kshhitj",
                Age = 20,
                Email="kshitijwk@gmail.com"},
                new Student{Id = 2,
                Name = "sol",
                Age = 20,
                Email="sol@gmail.com"}
            };

            return Ok(Students);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
            var student = new Student { Id = id, Name = "Kshitij", Age = 20, Email = "kshitij@gmail.com" };
            return Ok(student);
        }

        //post api/student
        [HttpPost]
        public IActionResult Create()
        {
            return Created("/api/student/3", new Student { Id = 3, Name = "New Student", Age = 18, Email = "new@gmail.com" });

        }

        //delete api/student/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
        //gett api/studdent/top
        [HttpGet("top")]
        public IActionResult GetTop()
        {
            var student = new Student { Id = 1, Name = "Top Student", Age = 20, Email = "top@gmail.com" };
            return Ok(student);
        }
    }
}
