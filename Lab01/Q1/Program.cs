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
            Console.WriteLine("Input your name :");
            string name = Console.ReadLine();   
            Console.WriteLine("Input batch :");
            double batch = double.Parse(Console.ReadLine());

            Console.WriteLine("Your name : " + name);
            Console.WriteLine("Batch : " + batch);

            Console.ReadLine();
        }
    }
}
