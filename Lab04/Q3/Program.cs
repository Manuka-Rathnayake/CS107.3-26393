using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in kilometers :");
            double km = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(km);

            Console.WriteLine("The distance in meters is:" + meters);
            Console.ReadLine();
        }
    }
}
