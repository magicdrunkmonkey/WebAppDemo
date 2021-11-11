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
            HttpContext.Session.SetInt32("guessCounter", 0);

            //Testing Session
            ViewBag.test = HttpContext.Session.GetInt32("RandomNumber");  //Endast med för att testa inmatningsfältet.
            ViewBag.guessResult = "Good Luck!";

            return View();
        }
        [HttpPost]
        public IActionResult GuessNumber(int guessedNumber)
        {
            GuessingGameModel guessingGameModel = new GuessingGameModel();

            int secretNumber = (int)HttpContext.Session.GetInt32("RandomNumber");
            guessingGameModel.SecretNumber = (int)HttpContext.Session.GetInt32("RandomNumber");     //Set SecretNumber in GuessingGameModel
                                                                                                    
            string result = guessingGameModel.CheckGuessedNumber(guessedNumber, secretNumber);       //Variabel för if-satsens villkor                   

            int counter = (int)HttpContext.Session.GetInt32("guessCounter");

            ViewBag.guessResult = result;
            ViewBag.countGuess = ++counter;             //Räknar upp och visar counter

            HttpContext.Session.SetInt32("guessCounter", counter);  //Sparar antalet gissningar

            if ( result == guessingGameModel.Answer)    //Använder sig av "get;" från GuessingGameModel.cs, om vinner genererar nytt hemligt nummer.
            {
                HttpContext.Session.SetInt32("RandomNumber", guessingGameModel.GenerateRandomNumber());
                secretNumber = (int)HttpContext.Session.GetInt32("RandomNumber");
                ViewBag.newGame = "Make a guess and play again?";
                HttpContext.Session.SetInt32("guessCounter", 0);
            }

            ViewBag.test = secretNumber;            
            
            return View();
        }
    }
}
