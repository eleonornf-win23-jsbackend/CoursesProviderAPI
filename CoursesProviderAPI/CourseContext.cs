using Microsoft.EntityFrameworkCore;

namespace CoursesProviderAPI
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options)
            : base(options)
        {
        }

        public DbSet<CourseModel> Courses { get; set; }
    }
}
