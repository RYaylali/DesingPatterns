using DP.Business.Abstract;
using DP.Entity.Concrete;
using DP.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace DP.UnitOfWork.Controllers
{
	public class DefaultController : Controller
	{
		private readonly ICustomerService _customerService;

		public DefaultController(ICustomerService customerService)
		{
			_customerService = customerService;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CustomerVM model)
		{
			var send = _customerService.TGetByID(model.SenderID);
			var buyer = _customerService.TGetByID(model.ReceiverID);
			send.CustomerBalance -= model.Amount;
			buyer.CustomerBalance += model.Amount;
			List<Customer> modifield = new List<Customer>()
			{
				send,
				buyer
			};
			_customerService.TMultiUpdate(modifield);
			return View();
		}
	}
}
