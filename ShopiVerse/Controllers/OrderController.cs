using Microsoft.AspNetCore.Mvc;

namespace ShopiVerse.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
