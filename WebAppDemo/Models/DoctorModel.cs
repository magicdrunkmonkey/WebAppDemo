using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{
    public class DoctorModel
    {
        public string Result { get; set; }
        public int Temperature { get; set; }
        
        public static string CheckTemperature(double temp)
        {
            string answer;

            if (temp < 5)
            {
                answer = "";
            }
            else if (temp > 37)
            {
                answer = "You have a fever";
            }
            else if (temp == 37)
            {
                answer = "You have no fever";
            }
            else if (temp < 37)
            {
                answer = "You have hypothermia";
            }
            else
            {
                answer = "This is not a valid input!";
            }

            return answer;
        }
        
    }
}
