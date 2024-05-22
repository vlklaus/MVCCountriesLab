using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052224_MVC_Countries_Lab
{
    public class Country
    {
        // properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        // constructors
        public Country (string _name, string _continent, List<string> _colors)
        {
            Name = _name;
            Continent = _continent;
            Colors = _colors;
        }


    }
}
