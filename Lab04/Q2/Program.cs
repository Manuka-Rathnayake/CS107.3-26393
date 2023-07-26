using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in kilometers :");
            double km = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter(km);

            Console.ReadLine();
        }
    }
}
