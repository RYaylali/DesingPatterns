using Microsoft.EntityFrameworkCore;
using RepositoryDP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDP.DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=RepositoryDB;Trusted_Connection=True;");
			base.OnConfiguring(optionsBuilder);
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
