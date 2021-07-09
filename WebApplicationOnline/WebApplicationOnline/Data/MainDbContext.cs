using Microsoft.EntityFrameworkCore;
using WebApplicationOnline.Entities;

namespace WebApplicationOnline.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Mountain> Mountains { get; set; }
        public MainDbContext(DbContextOptions<MainDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}
