using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}
