using DP.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DP.TemplateMethod.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult BasicPlanIndex()
		{
			NetflixPlans netflixPlans = new BasicPlan();
			ViewBag.v1=netflixPlans.PlanType("Temel Plan");
			ViewBag.v2=netflixPlans.CountPerson(1);
			ViewBag.v3=netflixPlans.Price(65.66);
			ViewBag.v4=netflixPlans.Content("Spor");
			ViewBag.v5=netflixPlans.Resolution("360px");
			return View();
		}
		public IActionResult StandardPlanIndex()
		{
			NetflixPlans netflixPlans = new BasicPlan();
			ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
			ViewBag.v2 = netflixPlans.CountPerson(2);
			ViewBag.v3 = netflixPlans.Price(85.66);
			ViewBag.v4 = netflixPlans.Content("Dizi");
			ViewBag.v5 = netflixPlans.Resolution("480px");
			return View();
		}
		public IActionResult UltraPlanIndex()
		{
			NetflixPlans netflixPlans = new BasicPlan();
			ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
			ViewBag.v2 = netflixPlans.CountPerson(3);
			ViewBag.v3 = netflixPlans.Price(115.66);
			ViewBag.v4 = netflixPlans.Content("Dizi-Spor");
			ViewBag.v5 = netflixPlans.Resolution("720px");
			return View();
		}
	}
}
