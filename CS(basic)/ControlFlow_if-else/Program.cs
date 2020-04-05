using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr = 15;

            if (hr > 0 && hr < 12)
            {
                Console.WriteLine("It is Moring");
            }

            if (hr > 12 && hr < 18)
            {
                Console.WriteLine("It is Afternoon");
            }

            if (hr > 18 && hr < 24)
            {
                Console.WriteLine("It is Evening");
            }


        }
    }
}
