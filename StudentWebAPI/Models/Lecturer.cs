namespace Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Lecturer
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public DateTime BirthDate { get; set; }
        [NotMapped]
        public List<Course> Courses { get; set; }
    }
}
