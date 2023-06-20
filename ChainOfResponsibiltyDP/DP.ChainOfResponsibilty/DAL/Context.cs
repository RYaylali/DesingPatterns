using Microsoft.EntityFrameworkCore;

namespace DP.ChainOfResponsibilty.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=ChainOfRepoDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
