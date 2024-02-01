using Microsoft.AspNetCore.Mvc;
using upp1.Models;

namespace upp1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult UsingModelClass1()
        {
            PersonModel model = new PersonModel();
            model.Age = 23;
            model.First_Name = "Maja";
            model.Last_Name = "Afzelius";
            return View(model);
        }
        public IActionResult UsingModelClass2()
        {
            PersonModel model1 = new PersonModel();
            model1.Age = 23;
            model1.First_Name = "Maja";
            model1.Last_Name = "Afzelius";

            PersonModel model2 = new PersonModel();
            model2.Age = 26;
            model2.First_Name = "Filip";
            model2.Last_Name = "Grendler";

            List<PersonModel> people = new List<PersonModel>();
            people.Add(model1);
            people.Add(model2);
            return View(people);
        }
        public IActionResult UsingModelClass3()
        {
            List<PersonModel> personer = new List<PersonModel>()
            {
                new PersonModel {First_Name= "Maja", Last_Name="Afzelius", Age=23},
                new PersonModel { First_Name="Fanny", Last_Name="Afzelius", Age=25}
            };
            ViewModel VM3 = new ViewModel();
            VM3.Persons = personer;
            VM3.date_time = DateTime.Now;
            VM3.SportClub = "Torpa AIS";

            return View(VM3);
        }
    }
}
