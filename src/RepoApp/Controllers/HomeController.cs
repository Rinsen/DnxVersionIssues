﻿using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RepoApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
