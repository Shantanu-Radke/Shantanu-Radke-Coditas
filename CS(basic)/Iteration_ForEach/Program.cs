using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "chris hemesworth";

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

        }
    }
}
