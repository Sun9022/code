using Microsoft.AspNetCore.Mvc;
using Tag_Helper.Models;

namespace Tag_Helper.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            if(ModelState.IsValid)
            {
                TempData["msg"] = "Products data submitted";
                TempData["productName"] = p.ProductName;
                TempData["price"] = p.Price;
                TempData["description"] = p.Description;
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}
