using Microsoft.EntityFrameworkCore;

namespace healthApp.Models
{
    public class dbContext:DbContext
    {

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        public DbSet<Run> runs { get; set; }
    }
}
