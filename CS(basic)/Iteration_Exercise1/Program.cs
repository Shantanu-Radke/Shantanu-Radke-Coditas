//count how many numbers divisible by 3 between 1 to 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j=0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    j++;
                }
                
   
            }
            Console.WriteLine(j + " Numbers are divisible by 3 ");
        }
    }
}
