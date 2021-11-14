using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {            
            return View();
        }
        public ActionResult Contact()
        {           
            return View();
        }
        public ActionResult Projects()
        {            
            return View();
        }
    }
}
