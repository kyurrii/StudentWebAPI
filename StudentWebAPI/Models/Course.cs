namespace Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int PassCredits { get; set; }
        [NotMapped] 
        public List<HomeTask> HomeTasks { get; set; }
        [NotMapped]
        public List<Lecturer> Lecturers { get; set; }
        [NotMapped]
        public List<Student> Students { get; set; }
    }
}