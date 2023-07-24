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
            Console.WriteLine("Input a radius :");
            double radius = double.Parse(Console.ReadLine());

            double circumference;
            double area;

            circumference = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;

            Console.WriteLine("Area :" + area);
            Console.WriteLine("circumference : " + circumference);

            Console.ReadLine();
        }
    }
}
