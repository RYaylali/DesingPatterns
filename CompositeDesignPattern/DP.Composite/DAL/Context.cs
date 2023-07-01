using Microsoft.EntityFrameworkCore;

namespace DP.Composite.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=CompositeDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
