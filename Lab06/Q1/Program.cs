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
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            
            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < size; i++)
            {
          
                array1[i] = int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("Enter values for the second array:");
            for (int i = 0; i < size; i++)
            {
                
                array2[i] = int.Parse(Console.ReadLine());
            }

            
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i];
                scalarSum += array2[i];
            }
            Console.WriteLine("Scalar Sum: " + scalarSum);

            
            int[] vectorSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
                Console.Write(vectorSum[i] + " ");
            }
            Console.WriteLine();
            

            
            int[] vectorProduct = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
                Console.Write(vectorProduct[i] + " ");
            }
            Console.WriteLine();
            

           
            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct += array1[i] * array2[i];
            }
            Console.WriteLine("Scalar Product: " + scalarProduct);

            Console.ReadLine();
        }
    }
}
