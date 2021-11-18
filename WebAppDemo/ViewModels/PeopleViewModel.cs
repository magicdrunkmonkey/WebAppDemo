using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

namespace WebAppDemo.ViewModels
{
    public class PeopleViewModel
    {
        /*Code Requirements:
         * • Models
         *      o Person – Person data.
         *      o CreatePersonViewModel – Use to prevent overposting and to use data
         *                                annotations to validate inputs when creating new person.
         *      o PeopleViewModel – container for the information you need in your people view.
         * • The table data should come from a view model, which should have a list of people, and
         *   the search phrase if one exists. 
         */

        public List<PersonModel> Persons = new List<PersonModel>();
    }
}
