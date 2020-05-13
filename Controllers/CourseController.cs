using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Models;
using SchoolPortal.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortal.Controllers
{
    [Route("api/course")]
    public class CourseController : Controller
    {
        // GET: api/<controller>
        [HttpGet("get")]
        public IActionResult Get()
        {
            var course = CourseRepo.GetAll();
            return Ok(course);
        }

        // POST api/<controller>
        [HttpPost("add")]
        public IActionResult AddCourse([FromBody] CourseModel course)
        {
            if (CourseRepo.Add(course))
            {
                return Ok("Course successfully added.");
            }
            else return BadRequest("This course already exists.");
        }

    }
}
