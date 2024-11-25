using Microsoft.AspNetCore.Mvc;

namespace EdgeCut.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
