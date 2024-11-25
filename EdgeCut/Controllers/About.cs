using Microsoft.AspNetCore.Mvc;

namespace EdgeCut.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
