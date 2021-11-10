using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{   
    public class GuessingGameModel
    {
        public int GuessedNumber { get; set; }

        Random randomNumber = new Random();

        public int GenerateRandomNumber()
        {
            int rndNumber = 0;

            return rndNumber;
        }

        public string CheckGuessedNumber(int number)
        {
            string answer ="";

            return answer;
        }

    }
}
