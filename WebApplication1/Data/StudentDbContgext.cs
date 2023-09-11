
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentDbContgext: DbContext
    {
        public StudentDbContgext(DbContextOptions<StudentDbContgext>options):base (options) 
        { 
        
        }

        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Sid = 1, Sname = "Faizan", Semail = "Faizan@gmail.com" },
                new Student { Sid = 2, Sname = "Faizan", Semail = "Faizan@gmail.com" },
                new Student { Sid = 3, Sname = "Faizan", Semail = "Faizan@gmail.com" }
                );
        }
    }
}
