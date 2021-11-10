using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult GuessNumber()
        {
            GuessingGameModel guessingGameModel = new GuessingGameModel();            

            HttpContext.Session.SetInt32("RandomNumber", guessingGameModel.GenerateRandomNumber());
            
            //Testing Session
            ViewBag.test = HttpContext.Session.GetInt32("RandomNumber");
            ViewBag.guessResult = "Good Luck!";

            return View();
        }
        [HttpPost]
        public IActionResult GuessNumber(int guessedNumber)
        {
            GuessingGameModel guessingGameModel = new GuessingGameModel();

            int secretNumber = (int)HttpContext.Session.GetInt32("RandomNumber");
            ViewBag.test = secretNumber;
            ViewBag.guessResult = guessingGameModel.CheckGuessedNumber(guessedNumber, secretNumber);
            
            return View();
        }
    }
}
