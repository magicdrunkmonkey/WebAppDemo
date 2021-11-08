using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FeverCheck()
        {
            /*
            double input = 0;
            string answer = "";
            if(input > 37.5)
            {
                answer = "You have a fever";
            }
            
            return View(answer);*/
            return View();
        }
    }
}
