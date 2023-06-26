using DP.Observer.DAL;
using DP.Observer.Models;
using DP.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DP.Observer.Controllers
{
	public class DefaultController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly ObserverObject _observerObject;
		public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
		{
			_userManager = userManager;
			_observerObject = observerObject;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(RegisterVM model)
		{
			var appUser = new AppUser()
			{
				Name = model.Name,
				Surname = model.Surname,
				Email = model.Email,
				UserName = model.Username,
				City = "DENİZLİ",
				District = "Pamukkale"
			};
			var result = await _userManager.CreateAsync(appUser, model.Password);
			if (result.Succeeded)
			{
				_observerObject.NotifyObserver(appUser);
				return View();
			}
			return View();
		}
	}
}
