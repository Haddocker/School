using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_method
{
    internal class CashRegister
    {
        public void PrintReceipt(Item[] items)
        {
            foreach (Item i in items)
            {
                i.Print();
            }
        }
    }
}
