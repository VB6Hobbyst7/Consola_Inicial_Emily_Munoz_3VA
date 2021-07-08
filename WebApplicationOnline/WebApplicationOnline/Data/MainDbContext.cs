using Microsoft.EntityFrameworkCore;
using WebApplicationOnline.Entities;

namespace WebApplicationOnline.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Mountain> Mountains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdo)\MSSQLocalDB;Initial Catalog=Mountain; Integrated Security=True;");
    }
}
