using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rain_class
{
    internal class Weather
    {
        public int TotalRainAmount(Rain day1, Rain day2)
        {
            int total = day1.RainAmount + day2.RainAmount;
            return total;
        }
    }
}
