using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using upp1.Models;

namespace upp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string ReturnString()
        {
            string s = "Detta är en text";
            return s;
        }

        public IActionResult ViewBagdemo()
        {
            String s = "detta är en text igen";
            int i = 5;

            ViewBag.error = s;
            ViewData["TheName"] = i;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}