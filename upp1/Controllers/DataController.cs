using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using upp1.Models;

namespace upp1.Controllers
{
    public class DataController : Controller
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddData()
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
        public IActionResult PassingParameter()
        {
            List<string> authors = new List<string>(5)
            {
                "Åsa",
                "Stina",
                "Sara",
                "Jenny",
                "Lisa"
            };
            return View(authors);

        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}