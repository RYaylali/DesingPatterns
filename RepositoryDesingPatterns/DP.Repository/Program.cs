using Microsoft.EntityFrameworkCore;
using RepositoryDP.BusinessLayer.Abstract;
using RepositoryDP.BusinessLayer.Concrete;
using RepositoryDP.DataAccessLayer.Abstract;
using RepositoryDP.DataAccessLayer.Concrete;
using RepositoryDP.DataAccessLayer.EntityFramework;

namespace DP.Repository
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddScoped<ICategoryService,CategoryManager>();
			builder.Services.AddScoped<ICategoryDal,EFCategoryDal>();
			builder.Services.AddScoped<IProductDal,EFProductDal>();
			builder.Services.AddScoped<IProductService,ProductManager>();
			builder.Services.AddDbContext<Context>();
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