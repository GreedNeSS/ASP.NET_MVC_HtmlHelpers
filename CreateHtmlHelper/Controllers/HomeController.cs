using Microsoft.AspNetCore.Mvc;

namespace CreateHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        List<string> people = new List<string>()
        {
            "GreedNeSS",
            "Marcus",
            "Henry"
        };

        public IActionResult Index()
        {
            return View(people);
        }
    }
}
