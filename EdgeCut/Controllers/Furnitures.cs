using Microsoft.AspNetCore.Mvc;

namespace EdgeCut.Controllers
{
    public class Furnitures : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
