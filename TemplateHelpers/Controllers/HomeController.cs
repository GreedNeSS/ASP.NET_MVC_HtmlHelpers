using Microsoft.AspNetCore.Mvc;
using TemplateHelpers.Models;
using System;

namespace TemplateHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            user.Id = Guid.NewGuid();
            return View("User", user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.Id = Guid.NewGuid();
            return View("Person", person);
        }
    }
}
