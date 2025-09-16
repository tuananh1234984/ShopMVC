using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("shop.html")]
        [HttpGet("shop")]
        public IActionResult Shop()
        {
            return View(); // Will resolve to Views/Product/Shop.cshtml
        }

        [HttpGet("product/details/{id}")]
        [HttpGet("details/{id}")]
        [HttpGet("product-details.html")]
        public IActionResult Details(int id)
        {
            // For now, render static view content. If you later add a strongly typed model, pass it to View(model).
            return View(); // Will resolve to Views/Product/Details.cshtml
        }

        
    }
}
