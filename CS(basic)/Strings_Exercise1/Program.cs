/// <summary>
/// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
/// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
/// display a message: "Consecutive"; otherwise, display "Not Consecutive".
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separeted by hypens");
            var numbers = Console.ReadLine();

            var input = new List<int>();

            foreach (var num in numbers.Split('-')) 
            {
                input.Add(Convert.ToInt16(num));
            }

            var result = true;

            for (var i = 1; i < input.Count; i++)
            {
                if (input[i] != input[i - 1] + 1)
                {
                    result = false;
                    break;
                }
            }

            if (result == true)
            { Console.WriteLine("Consecutive"); }

            else
                Console.WriteLine("Not Consecutive");


        }
    }
}
