using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TypedHelpers.Models;

namespace TypedHelpers.Controllers
{
    public class HomeController : Controller
    {
        private static List<Person> _people = new List<Person>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            if (person == null) return View("Error");
            person.Id = Guid.NewGuid();
            _people.Add(person);
            return Json(person);
        }

        public IActionResult People()
        {
            return Json(_people);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}