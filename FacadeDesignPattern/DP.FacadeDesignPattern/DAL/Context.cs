using Microsoft.EntityFrameworkCore;

namespace DP.FacadeDesignPattern.DAL
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=FacadeDb;Trusted_Connection=True;");
			base.OnConfiguring(optionsBuilder);
		}
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
	}
}

