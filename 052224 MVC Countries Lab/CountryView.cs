using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052224_MVC_Countries_Lab
{
    public class CountryView
    {
        // properties
        public Country DisplayCountry { get; set; }

        // constructors
        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }

        // methods
        public void Display()
        {          
            Console.WriteLine($"Name: {DisplayCountry.Name}, Continent: {DisplayCountry.Continent}, Colors: {string.Join(", ",DisplayCountry.Colors)}");            
        }

    }
}
