using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

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
            return View();        
        }
        [HttpPost]
        public IActionResult FeverCheck(double temperature)
        {
            ViewBag.name = DoctorModel.CheckTemperature(temperature);
            return View();                        
        }            
    }
}
