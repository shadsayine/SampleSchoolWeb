using Microsoft.EntityFrameworkCore;
using SampleSchoolWeb.Models;

namespace SampleSchoolWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> SchoolDB { get; set; }
    }
}
