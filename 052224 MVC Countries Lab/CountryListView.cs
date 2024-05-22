﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052224_MVC_Countries_Lab
{
    public class CountryListView
    {
        // properties
        public List<Country> Countries { get; set; }

        // constructors
        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        // methods
        public void Display()
        {
            for (int i = 0; i <Countries.Count; i++)
            {                
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }


    }
}
