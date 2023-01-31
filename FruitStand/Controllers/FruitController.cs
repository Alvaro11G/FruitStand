using Microsoft.AspNetCore.Mvc;

namespace FruitStand.Controllers
{
    public class FruitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
