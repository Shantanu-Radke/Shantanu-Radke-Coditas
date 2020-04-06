/*Ask user to enter the name and reverse it using array and store it in string and display
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name ");
            var str=(Console.ReadLine());

            var name = new char[100];
            int j = 0;
            for (var i = (str.Length-1); i >= 0; i--,j++)
            {
                name[j] = str[i];
            }

           string nm=new string(name);

            Console.WriteLine(nm);
        }
    }
}
