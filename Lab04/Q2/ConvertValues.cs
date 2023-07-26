using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class ConvertValues
    {
        public void KilometerToMeter(double kmValue)
        {
            double meters = kmValue * 1000;
            Console.WriteLine($"The distance in meters is: " + meters);
        }
      
    }
}
