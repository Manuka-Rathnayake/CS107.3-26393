using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("The given number is a even number");
            }
            else
            {
                Console.WriteLine("The given number is a odd number");
            }

            Console.ReadLine();
        }
    }
}
