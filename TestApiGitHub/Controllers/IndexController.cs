﻿using Microsoft.AspNetCore.Mvc;

namespace TestApiGitHub.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
