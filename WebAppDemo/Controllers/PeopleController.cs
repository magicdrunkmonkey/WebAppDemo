using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;
using WebAppDemo.ViewModels;


namespace WebAppDemo.Controllers
{
    public class PeopleController : Controller
    {        
        public IActionResult People() 
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { PersonId = 1, Name = "George Sydby", PhoneNumber = 0737323814, City = "Göteborg" });
            people.Add(new PersonModel { PersonId = 2, Name = "Kalle Anka", PhoneNumber = 0737123456, City = "Ankeborg" });

            return View(people);
        }
        public IActionResult CreatePerson()
        {
            return View();
        }
        public IActionResult DeletePerson()
        {
            return View();
        }
        public IActionResult FindPerson()
        {
            return View();
        }
        public IActionResult PeopleView()
        {
            return View();
        }
        
    }
}
