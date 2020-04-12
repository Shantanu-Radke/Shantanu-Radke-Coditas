/// <summary>
/// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
/// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
/// any duplicates. If so, display "Duplicate" on the console.
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The numbers separeted by hypen");
            var numbers = Console.ReadLine();


            if (String.IsNullOrWhiteSpace(numbers))
                return;

            var input = new List<int>();
           var duplicate = false;

            foreach (var num in numbers.Split('-'))
            {
                
                  input.Add(Convert.ToInt16(num));
            }    

            var uniques =new List<int>();

            foreach (var nm in input)
            {
                if (!uniques.Contains(nm))
                {
                    uniques.Add(nm);
                }

                else
                {
                    duplicate = true;
                    break;

                }
            }

            if (duplicate == true)
                Console.WriteLine("Duplicate");

            

        }
    }
}
