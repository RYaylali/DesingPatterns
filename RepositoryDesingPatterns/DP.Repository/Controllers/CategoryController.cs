using Microsoft.AspNetCore.Mvc;
using RepositoryDP.BusinessLayer.Abstract;
using RepositoryDP.EntityLayer.Concrete;

namespace DP.Repository.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult Index()
		{
			var values = _categoryService.TGetAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddCategory(Category model)
		{
			_categoryService.TInsert(model);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			_categoryService.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateCategory(Category model)
		{
			_categoryService.TUpdate(model);
			return RedirectToAction("Index");
		}
	}
}
