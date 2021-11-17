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
        [HttpPost]
        public IActionResult People(string name, string city)  //Searach Name or City
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult People(int ID, string name, int phoneNumber, string city)  //Searach Name or City
        {

            return View();
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
