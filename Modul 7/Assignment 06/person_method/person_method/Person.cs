using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace person_method
{
    internal class Person
    {
        public string Name {  get; set; }
        public string Email {  get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"E-mail: {Email}");
        }
    }
}
