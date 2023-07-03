using DP.IteratorDesignPattern.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DP.IteratorDesignPattern.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			VisitRouteMover visitRouteMover = new VisitRouteMover();
			List<string> strings = new List<string>();

			visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Almanya", CityName = "Berlin", VisitPlaceName = "Berlin Kapısı" });
			visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Fransa", CityName = "Paris", VisitPlaceName = "Eyfel" });
			visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "İtalya", CityName = "Roma", VisitPlaceName = "Kolezyum" });
			visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "İtalya", CityName = "Venedik", VisitPlaceName = "Gondol" });
			visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Çekya", CityName = "Prag", VisitPlaceName = "Meydan" });
			var iterator = visitRouteMover.CreateIterator();
			while (iterator.NextLocation())
			{
				strings.Add(iterator.CurrentItem + " " + iterator.CurrentItem.VisitPlaceName + " " + iterator.CurrentItem.CityName);
			}
			ViewBag.v = strings;
			return View();
		}
	}
}
