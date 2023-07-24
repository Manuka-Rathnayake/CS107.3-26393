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
            Console.WriteLine("Input Salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Input tax rate :");
            double tax = double.Parse(Console.ReadLine());

            double newsalary;

            newsalary = salary - (salary * tax/100);

            Console.WriteLine("New salary :" +  newsalary);
            Console.ReadLine();
        }
    }
}
