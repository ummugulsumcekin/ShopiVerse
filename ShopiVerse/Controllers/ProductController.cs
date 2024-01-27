using Microsoft.AspNetCore.Mvc;

namespace ShopiVerse.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
