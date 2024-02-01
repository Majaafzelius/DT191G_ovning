using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using upp1.Models;

namespace upp1.Controllers
{
    public class StateController : Controller
    {
        public IActionResult SetState()
        {
            HttpContext.Response.Cookies.Append("user_id", "1");
            HttpContext.Session.SetString("mySession", "userid = 1 i sessionsvariabler");
            return View();
        }
        public IActionResult GetState()
        {
            var userId = HttpContext.Request.Cookies["user_id"];
            ViewBag.cookiecontent = userId;
            ViewBag.sessioncontent = HttpContext.Session.GetString("mySession");
            return View();
        }

        [HttpPost]
        public IActionResult SetState(PersonModel person)
        {
            return View();
        }


        [HttpGet]
        public IActionResult SetState2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetState2(PersonModel person)
        {
            string p = JsonConvert.SerializeObject(person);
            HttpContext.Session.SetString("mySession", p);
            return RedirectToAction("GetState2");
        }
        [HttpGet]
        public IActionResult GetState2()
        {
            PersonModel pm = new PersonModel();
            string jsonstring = HttpContext.Session.GetString("mySession");
            pm = JsonConvert.DeserializeObject<PersonModel>(jsonstring);
            ViewBag.jsonstring = jsonstring;
            return View(pm);
        }
    }
}
