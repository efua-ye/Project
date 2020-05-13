using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Repositories;
using SchoolPortal.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortal.Controllers
{
    [Route("api/studCourseAssignment")]
    public class StudentCourseAssignmentController : Controller
    {

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var studassignment = assignmentRepo.GetAssignment(id);
            return Ok(studassignment);
        }
        /*GET: api/<controller>
        [HttpGet("get")]
        public IActionResult Get()
        {
      
        }

         GET api/<controller>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
