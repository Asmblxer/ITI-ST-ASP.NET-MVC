using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using MvcLab4.Context;

namespace MvcLab4.Models
{
    [Table("Courses")]
    public class Course
    {
        public int CourseId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
    }

    [Table("Students")]
    public class Student
    {   
        public int StudentId { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Email { get; set; } = "example@email.com";
        [ForeignKey("Course")]
        public int? CourseId { get; set; }
    }

}