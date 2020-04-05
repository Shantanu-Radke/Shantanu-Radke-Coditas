using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number");
            a =Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            b = Convert.ToInt16(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Both Equal");
            }

            else if (a > b)
            {
                Console.WriteLine("Greater no. is " + a);
            }

            else 
            {
                Console.WriteLine("Greater no. is " + b);
            }




        }
    }
}
