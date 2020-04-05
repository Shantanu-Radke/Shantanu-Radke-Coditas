//Find the factorial of enterd number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j=1;
            Console.WriteLine("Enter the num");
            i = Convert.ToInt16(Console.ReadLine());

            while (i != 0)
            {
                j = i * j;
                i--;
            }

            Console.WriteLine("Factorial is " + j);
        }
    }
}
