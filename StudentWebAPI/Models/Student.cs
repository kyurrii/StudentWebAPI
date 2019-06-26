namespace Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {

        public string Name { get; set; }

        public int Id { get; set; }
        [NotMapped]
        public List<Course> Courses { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string GitHubLink { get; set; }

        public string Notes { get; set; }
        [NotMapped]
        public List<HomeTaskAssessment> HomeTaskAssessments { get; set; }
    }
}