﻿using Microsoft.AspNetCore.Mvc;

namespace EdgeCut.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
