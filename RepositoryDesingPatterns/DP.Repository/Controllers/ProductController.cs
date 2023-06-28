using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;
using RepositoryDP.BusinessLayer.Abstract;
using RepositoryDP.EntityLayer.Concrete;

namespace DP.Repository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

		public ProductController(IProductService productService, ICategoryService categoryService)
		{
			_productService = productService;
			_categoryService = categoryService;
		}

		public IActionResult Index()
        {
            var values = _productService.TGetAll();
            return View(values);
        }
        public IActionResult Index2()
        {
            var values = _productService.TGetProductListWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            _productService.TInsert(model);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            List<SelectListItem> values = (from x in _categoryService.TGetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _productService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product model)
        {
            _productService.TUpdate(model);
            return RedirectToAction("Index");
        }
    }
}
