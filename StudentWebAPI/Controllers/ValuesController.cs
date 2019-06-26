using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace StudentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private static List<Student> Students = new List<Student>() { new Student() { Name = "Taras", Id = 1 }, new Student() { Name = "Ivanna", Id = 2 } };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
           // return new string[] { "value1", "value2" };

            return Students;

    }
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent([FromRoute]int id)
        {
            var result = Students.FirstOrDefault(s => s.Id == id);
            return result;
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
