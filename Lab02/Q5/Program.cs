using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Input number : ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The given number is even number");
                }
                else
                {
                    Console.WriteLine("The given number is odd number");
                }
            }

            Console.ReadLine();
        }
    }
}
