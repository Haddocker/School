using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizens_method
{
    internal class City
    {
        private string Name;
        private int Population;

        public City(string name)
        {
            Name = name;
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

    }
}
