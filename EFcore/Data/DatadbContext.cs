using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFcore.Data
{
    public class DatadbContext : DbContext
    {
        public DatadbContext() : base("UniContext") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
