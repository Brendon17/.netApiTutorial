using Microsoft.EntityFrameworkCore;

namespace ApiTutorial.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Item> TodoItems { get; set; }
    }
}