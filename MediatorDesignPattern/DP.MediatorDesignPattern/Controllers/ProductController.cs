using DP.MediatorDesignPattern.MediatorPattern.Commands;
using DP.MediatorDesignPattern.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace DP.MediatorDesignPattern.Controllers
{
	public class ProductController : Controller
	{
		private readonly IMediator _mediator;
		public ProductController(IMediator mediator)
		{
			_mediator = mediator;
		}
		public async Task<IActionResult> Index()
		{
			var values = await _mediator.Send(new GetAllProductQuery());
			return View(values);
		}
		public async Task<IActionResult> GetProduct(int id)
		{
			var values = await _mediator.Send(new GetProductByIDQuery(id));
			return View(values);
		}
		public async Task<IActionResult> DeleteProduct(int id)
		{
			await _mediator.Send(new RemoveProductCommand(id));
			return RedirectToAction("Index");
		}
		[HttpGet]
		public async Task<IActionResult> UpdateProduct(int id)
		{
			var values = await _mediator.Send(new GetProductUpdateByIdQuery(id));
			return View(values);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductCommand model)
		{
			await _mediator.Send(model);
			return RedirectToAction("Index");

		}
		[HttpGet]
		public IActionResult AddResult()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddResult(CreateProductCommand model)
		{
			await _mediator.Send(model);
			return RedirectToAction("Index");
		}
	}
}
