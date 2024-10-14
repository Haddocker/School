using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_method_math
{
    class CalculateMath
    {
        private int Total;

        public void AddMethod(int number)
        {
            Total = Total + number;
        }

        public int SumMethod()
        {
            return Total;
        }
    }
}
