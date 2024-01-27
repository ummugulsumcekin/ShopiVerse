using Microsoft.AspNetCore.Mvc;

namespace ShopiVerse.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
