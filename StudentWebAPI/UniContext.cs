using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace StudentWebAPI
{
    public class UniContext:DbContext
    {
        public UniContext(DbContextOptions<UniContext> options)
           : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
