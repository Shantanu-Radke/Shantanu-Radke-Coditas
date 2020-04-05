//Print the sum of numbers entered by user 
//ask user to enter as much times he wants to enter or "ok" to stop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;// string str = "";
           while(true)
           {

            Console.WriteLine("Enter The number OR write ok to stop");
            var str=Console.ReadLine();
            if (str == "ok")
                break;
            i = i + Convert.ToInt16(str);
           }

           Console.WriteLine("Sum is " + i);
        }
    }
}
