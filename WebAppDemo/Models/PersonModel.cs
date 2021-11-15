using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{
    /*
     * Create a MVC project with a controller with one view to displays a list of people.
     * These people should have a name, phone number and city
     * public class PersonModel
     */
    public class PersonModel
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
