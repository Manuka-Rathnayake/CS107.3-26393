using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class MyArray
    {
        public int MinValue(int[] arr1)
        {
            int min = arr1[0];

            for (int i = 1; i < arr1.Length; i++)
            {

                if (arr1[i] < min)
                {
                    min = arr1[i];
                }

            }

            return min;

        }

        public int MaxValue(int[] arr1)
        {
            int max = arr1[0];

            for (int i = 1; i < arr1.Length; i++)
            {

                if (arr1[i] > max)
                {
                    max = arr1[i];
                }

            }

            return max;

        }

        public int Average(int[] arr1)
        {
            int total = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                total += arr1[i];

            }

            int avg = total / 10;

            return avg;

        }
    }
}
