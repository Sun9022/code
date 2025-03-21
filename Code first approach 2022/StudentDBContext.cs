using Microsoft.EntityFrameworkCore;

namespace Code_First_Approach.Models
{
    public class StudenDBContext: DbContext
    {
        public StudenDBContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Student> students { get; set; }
    }
}
