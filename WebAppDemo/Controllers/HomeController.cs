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
            ViewBag.Message = "Jag chansar och gissar att detta är en controller för About." +
                              "Containing information about yourself (CV, for example).";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Jag chansar och gissar att detta är en controller för Contact." +
                              "Containing your contact information (Use fake info if you want).";
            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "Containing the GitHub links to your assignments you have finished with " +
                              "a small description about them.";
            return View();
        }
    }
}
