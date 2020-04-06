/* Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
  display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, 
 sort them and display the result on the console.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>();

            while (num.Count < 5)
            {
                Console.Write("Enter a number: ");
                var nm = Convert.ToInt32(Console.ReadLine());
                if (num.Contains(nm))
                {
                    Console.WriteLine("You've previously entered " + nm);
                    continue;
                }

                num.Add(nm);
            }

            num.Sort();

            foreach (var nm in num)
                Console.WriteLine(nm);
        }
    }
}
