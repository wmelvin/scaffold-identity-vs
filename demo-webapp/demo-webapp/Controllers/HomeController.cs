﻿using Microsoft.AspNetCore.Mvc;

namespace demo_webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
