using DP.FacadeDesignPattern.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DP.FacadeDesignPattern.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product model)
        {
            context.Products.Add(model);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
