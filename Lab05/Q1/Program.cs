using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CalculateValues objCal = new CalculateValues();
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division ");

            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Number :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a another Number :");
            double b = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your answer is:" + objCal.Addition(a, b));
                    break;
                case 2:
                    Console.WriteLine("Your answer is:" + objCal.Subtraction(a, b));
                    break;
                case 3:
                    Console.WriteLine("Your answer is:" + objCal.Multiplication(a, b));
                    break;
                case 4:
                    Console.WriteLine("Your answer is:" + objCal.Division(a, b));
                    break;
                default:
                    Console.WriteLine("Enter a correct value");
                    break;
            }
            Console.ReadLine();

        }
    }
}
