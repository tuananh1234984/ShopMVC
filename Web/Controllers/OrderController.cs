using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("checkout.html")]
        [HttpGet("checkout")]
        public IActionResult Checkout()
        {
            return View(); // Resolves to Views/Order/Checkout.cshtml
        }
    }
}
