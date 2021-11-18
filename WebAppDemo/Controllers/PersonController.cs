using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;
using WebAppDemo.ViewModels;

namespace WebAppDemo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            if (PersonModel.listOfPersons.Count < 1)
            {
                PersonModel.GeneratePersons();
            }

            return View();
        }
        public IActionResult Persons()
        {
            PersonModel personModel = new PersonModel();
            return View(personModel);
        }

        public IActionResult PeopleManagement()
        {
            PeopleViewModel pvm = new PeopleViewModel();
            pvm.Persons = PersonModel.listOfPersons;
            return View(pvm);
        }
    }
}
