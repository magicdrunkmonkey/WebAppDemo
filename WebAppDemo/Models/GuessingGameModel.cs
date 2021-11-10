using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{   
    public class GuessingGameModel
    {
                
        //Getter, Setter och annat
        public int GuessedNumber { get; set; }
        public int RandomNumber { get; set; }  

        public int GenerateRandomNumber()
        {
            Random randomNumber = new Random();
            int rnd = randomNumber.Next(1, 101);
            return rnd;
        }

        public string CheckGuessedNumber(int guessNumber, int secretNumber)
        {
            string answer ="";

            if (guessNumber < secretNumber)
            {
                answer = "The guess is to low";
            }
            else if(guessNumber > secretNumber)
            {
                answer = "The guess is to high";
            }else if(guessNumber == secretNumber)
            {
                answer = "Correct guessed, you won! Play a new Game?";                
            }

            return answer;
        }

    }
}
