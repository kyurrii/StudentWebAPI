using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI
{
    public class StudentsRepo
    {
        private static List<Student> Students = new List<Student>() { new Student() { Name = "Taras", Id = 1 }, new Student() { Name = "Ivanna", Id = 2 } };

        public StudentsRepo() { }

        public List<Student> GetAll()
        {

            return Students;

        }

    }
}
