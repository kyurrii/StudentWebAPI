using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        //private readonly StudentsRepo repo;

        //public StudentController(StudentsRepo repo)   // dependency injection of SudentRepo class instance
        //{
        //    this.repo = repo;
        //}
        private static readonly List<Student> studs = new List<Student>() { new Student() { Name = "Taras", Id = 1 }, new Student() { Name = "Nino", Id = 2 } };

        private UniContext context;
        public StudentController(UniContext context)   // dependency injection of SudentRepo class instance
        {
            this.context = context;

            if (context.Students.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.

                foreach (var item in studs)
                {
                  context.Students.Add( item);
                }
                
                context.SaveChanges();
            }
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var result = context.Students;
           
            return result;
        }



        [HttpGet ("{id}")] 
        public ActionResult<Student> GetStudent([FromRoute]int id)
        {
            var result = context.Students.FirstOrDefault(s => s.Id == id);
           // var result = Students.FirstOrDefault(s => s.Id == id);
            return result;
        }




        // POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student item)
        {
            context.Students.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(Student), new { id = item.Id }, item);
        }





        // PUT api/<controller>/5
       
        [HttpPut("{id}")]
        public async Task<IActionResult> EditStudent(long id, Student item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(long id)
        {
            var todoItem = await context.Students.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            context.Students.Remove(todoItem);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
