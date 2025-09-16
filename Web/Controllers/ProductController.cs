using Microsoft.AspNetCore.Mvc;

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
    }
}
