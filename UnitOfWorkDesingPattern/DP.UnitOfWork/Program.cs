
using DP.Business.Abstract;
using DP.Business.Concrete;
using DP.DataAccess.Abstract;
using DP.DataAccess.Concrete;
using DP.DataAccess.EntityFramework;
using DP.DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace DP.UnitOfWork
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddScoped<ICustomerDal,EfCustomerDal>();
			builder.Services.AddScoped<ICustomerService,CustomerManager>();
			builder.Services.AddScoped<IUowDal,UowDal>();
			builder.Services.AddDbContext<Context>(opt =>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}