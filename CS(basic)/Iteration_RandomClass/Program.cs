//Using Random class to generate a password with help of ascii numbers of characters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new Random();
            for (var i = 0 ; i < 10 ; i++)
            {
                Console.Write((char)str.Next(97, 120));
            }

            Console.WriteLine();
        }
    }
}
