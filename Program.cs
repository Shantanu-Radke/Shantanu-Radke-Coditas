using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        public enum days
        {
             sun=1;
             mon=2;
             tue=3;
             wed=4;
             thu=5;
             
        
        }

        static void Main(string[] args)
        {
            int a= days.mon;

            Console.WriteLine("monday is " + a);

        }
    }
}
