using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    abstract class InputNum
    {
        protected int num1;
        protected int num2;

        public InputNum()
        {
            Console.Write("Enter two numbers :");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

        }
    }
}
