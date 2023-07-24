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
            Console.WriteLine("Input radius");
            double radius = double.Parse(Console.ReadLine());
            double result;
            result = Math.PI * radius * radius;

            Console.WriteLine("Area : " + result);
            
            Console.ReadLine();
        }
    }
}
