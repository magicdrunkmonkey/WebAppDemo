using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{
    public class PersonModel
    {
        public string PersonName { get; set; }
        public string PersonPhoneNumber { get; set; }
        public string PersonCity { get; set; }

        public static List<PersonModel> listOfPersons = new List<PersonModel>();

        public static void GeneratePersons()
        {
            listOfPersons.AddRange(new List<PersonModel>
            {
                new PersonModel {PersonName="Kalle Anka", PersonPhoneNumber="031-123456", PersonCity="Ankeborg"},
                new PersonModel {PersonName="Musse Pigg", PersonPhoneNumber="031-789456", PersonCity="Trelleborg"},
                new PersonModel {PersonName="Jan Långben", PersonPhoneNumber="031-456123", PersonCity="Oslo"}
            });
        }
    }
}
