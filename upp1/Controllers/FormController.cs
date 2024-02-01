using Microsoft.AspNetCore.Mvc;
using upp1.Models;

namespace upp1.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Form1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form1(PersonModel pm, string cars)
        {
            ViewBag.fullname = pm.First_Name + " " + pm.Last_Name + " " + pm.Age + " Du valde: " + cars;
            return View();
        }
        public IActionResult Form2(PersonModel pm, string cars)
        {
            ViewBag.fullname = pm.First_Name + " " + pm.Last_Name + " " + pm.Age + " Du valde: " + cars;
            return View();
        }
    }
}
