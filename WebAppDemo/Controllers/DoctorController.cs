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
            /* FUNKAR INTE 
            int x = Convert.ToInt32(TempData["Data1"]);
            
            //double input = 0;
            string answer = "test";
            if(x > 37.5)
            {
                answer = "You have a fever";
                ViewBag.message = answer;
            }
            else
            {
                answer = "You have no fever";
                ViewBag.message = answer;
            } 
            //return View(answer);*/

            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(double temperature)
        {
            string answer;            

            if (temperature <5 )
            {
                answer = "";
            }
            else if (temperature > 37)
            {
                answer = "You have a fever";
            }
            else if (temperature == 37)
            {
                answer = "You have no fever";
            }
            else if (temperature < 37)
            {
                answer = "You have hypothermia";
            }
            else
            {
                answer = "This is not a valid input!";
            }

            ViewBag.name = string.Format(answer);

            return View();
        }

            /*  FUNKAR INTE
            public IActionResult FeverTemperatureCheck()
            {
                /* SEPARAT IACTION FUNKAR INTE
                int x = Convert.ToInt32(TempData["Data1"]);

                double input = 0;
                string answer = "";
                if (x > 37.5)
                {
                    answer = "You have a fever";
                }
                else
                {
                    answer = "You have no fever";
                }

                ViewBag.message(answer);

                return View();
            }*/
        }
}
