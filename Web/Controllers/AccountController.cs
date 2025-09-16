﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login.html")]
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
