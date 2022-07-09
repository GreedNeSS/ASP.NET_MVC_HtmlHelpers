using Microsoft.AspNetCore.Mvc;
using FormItems.Models;
using System;

namespace FormItems.Controllers
{
    public class HomeController : Controller
    {
        static List<Person> people = new List<Person>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person? person)
        {
            if (person != null)
            {
                person.Id = Guid.NewGuid();
                people.Add(person);
            }

            return Json(person);
        }

        public IActionResult People()
        {
            return View(people);
        }

        [HttpPost]
        public IActionResult People(Guid? id)
        {
            if (id is null)
            {
                return BadRequest(new {message = "Некоректные данные"});
            }

            var person = people.FirstOrDefault(x => x.Id == id);

            if (person is null)
            {
                return BadRequest(new { message = "Пользователь не существует!" });
            }

            return Json(person);
        }

        public IActionResult EnumList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnumList(Languages? language)
        {
            if (language is null)
            {
                return BadRequest(new { message = "Некоректные данные" });
            }
            List<Person> persons = people.Where(x => x.Languages.Contains(language.ToString() ?? "")).ToList();

            if (persons.Count == 0)
            {
                return BadRequest(new { message = "Пользователей знающих данную техногогию не существует!" });
            }

            return Json(persons);
        }
    }
}
