using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr = 10;

            if (hr > 0 && hr < 12)
            {
                Console.WriteLine("morning");
            }

            if (hr > 12 && hr < 18)
            {
                Console.WriteLine("afternoon");
            }
            if (hr > 18 && hr < 24)
            {
                Console.WriteLine("night");
            }
        }
    }
}
