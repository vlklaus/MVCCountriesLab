using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052224_MVC_Countries_Lab
{
    public class CountryController
    {        
        List<Country> CountryDB = new List<Country>()
        {
            new Country("China", "Asia", new List<string> {"Red", "Yellow"}),
            new Country("United States", "North America", new List<string> {"Red", "White", "Blue"}),
            new Country("Germany", "Europe", new List<string> {"Black", "Red", "Gold"}),
            new Country("Colombia", "South America", new List<string> {"Yellow", "Blue", "Red"}),
            new Country("Australia", "Australia", new List<string> {"Green", "Gold"})
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            CountryListView view = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            view.Display();
            int choice = int.Parse(Console.ReadLine());            
            CountryAction(CountryDB[choice]);
            
            while (true)
            {
                Console.WriteLine("Would you like to learn about another country? (y/n)");
                string learnMoreCountry = Console.ReadLine().ToLower().Trim();

                if (learnMoreCountry == "n") return;
                else if (learnMoreCountry == "y")
                {
                    WelcomeAction();
                }
                else Console.WriteLine("y/n?");
            }
        }
    }
}
