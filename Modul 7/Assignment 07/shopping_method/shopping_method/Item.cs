using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_method
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C2}");
        }
    }
}
