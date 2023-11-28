using Microsoft.EntityFrameworkCore;
using MvcLab4.Models;

namespace MvcLab4.Context
{
    public class AcademyContext : DbContext
    {        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options) { }
    }
}