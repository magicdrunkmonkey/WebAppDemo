using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

namespace WebAppDemo.ViewModels
{
    /*  o PeopleViewModel – container for the information you need in your people view.
     *  
     *  • The table data should come from a view model, which should have a list of people, and
     *    the search phrase if one exists. 
     */

    public class PeopleViewModel
    {
        public PersonModel ViewPerson { get; set; }  


        public PersonModel ViewPeople()
        {

            return null;
        }
        /* FUNKADE INTE
        List<PersonModel> people = new List<PersonModel>();
        
        people.Add(new PersonModel { PersonId = 1, Name = "George Sydby", PhoneNumber = 0737323814, City = "Göteborg" });
        people.Add(new PersonModel { PersonId = 2, Name = "Kalle Anka", PhoneNumber = 0737123456, City = "Ankeborg" });     */
    }
}
