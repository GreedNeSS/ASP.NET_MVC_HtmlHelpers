using Microsoft.AspNetCore.Mvc;
using System;

namespace URL_Helper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string? action = Url.Action("Index", "Home", new { name = "Greed", id = 342 });
            string? routeUrl = Url.RouteUrl(new { controller = "Home", action = "Index", name = "Greed", id = 342 });
            string content = Url.Content("~/lib/jquery/dist/jquery.js");
            return Content($"Action => {action}\nRouteUrl => {routeUrl}\nContent => {content}");
        }
    }
}
