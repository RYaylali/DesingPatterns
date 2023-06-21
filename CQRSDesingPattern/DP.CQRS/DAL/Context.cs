using Microsoft.EntityFrameworkCore;

namespace DP.CQRS.DAL
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=CQRSDB;Trusted_Connection=True;");
			base.OnConfiguring(optionsBuilder);
		}
		public DbSet<Product> Products { get; set; }
	}
}
