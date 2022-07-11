using Microsoft.AspNetCore.Mvc;
using System;

namespace LinkGeneration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(int? id)
        {
            if (id is not null)
            {
                ViewBag.Id = id;
            }

            return View();
        }

        public IActionResult Users(int? id, string name)
        {
            if (id is not null)
            {
                ViewBag.Id = id;
                ViewBag.Name = name;
            }

            return View();
        }
    }
}
