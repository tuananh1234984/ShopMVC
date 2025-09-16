using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("cart.html")]
        [HttpGet("cart")]
        public IActionResult Cart()
        {
            return View();
        }
    }
}
