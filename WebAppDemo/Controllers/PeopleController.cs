using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index() 
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { Name = "George Sydby", PhoneNumber = 0737323814, City = "Göteborg" });
            people.Add(new PersonModel { Name = "Kalle Anka", PhoneNumber = 0737123456, City = "Ankeborg" });

            return View(people);
        }
        public IActionResult CreatePerson()
        {
            return View();
        }
        public IActionResult FindPerson()
        {
            return View();
        }
    }
}
