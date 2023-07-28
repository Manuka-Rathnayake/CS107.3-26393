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
            int[] arr1 = new int[4];

            for(int i=0; i<arr1.Length; i++)
            {
                Console.WriteLine("Input values for the array :");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            MyArray objarr1 = new MyArray();

            Console.WriteLine("Minimum value is" + objarr1.MinValue(arr1));
            Console.WriteLine("Maximum value is" + objarr1.MaxValue(arr1));
            Console.WriteLine("Average value is" + objarr1.Average(arr1));
            

            Console.ReadLine();
        }
    }
}
