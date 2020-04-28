using ETMS.Data;
using Microsoft.EntityFrameworkCore;

namespace ETMS.Data
{
    public class ETMSContext : DbContext
    {
        public ETMSContext(DbContextOptions<ETMSContext> options)
   :         base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EmployeeCourse> EmployeeCourses { get; set; }
    }
}
