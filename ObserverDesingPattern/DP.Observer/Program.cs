using DP.Observer.DAL;
using DP.Observer.ObserverPattern;

namespace DP.Observer
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<Context>();
			builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
			builder.Services.AddSingleton<ObserverObject>(sp =>
			{
				ObserverObject observer = new();
				observer.RegisterObserver(new CreateWelcomeMessage(sp));
				observer.RegisterObserver(new CreateMaganizeAnnocuncement(sp));
				observer.RegisterObserver(new CreateDiscountCode(sp));
				return observer;
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