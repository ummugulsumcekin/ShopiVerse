using Microsoft.AspNetCore.Mvc;

namespace ShopiVerse.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
