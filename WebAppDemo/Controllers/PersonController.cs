using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

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
    }
}
