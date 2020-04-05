using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        public enum season
        {
            Summer,
            Winter,
            Rainy,
            Spring
        }


        static void Main(string[] args)
        {    
            var ThisSeason=season.Summer;

            switch (ThisSeason)
            {
                case season.Summer:
                    Console.WriteLine("It is hot ");
                    break;


                    case season.Winter:
                    Console.WriteLine("It is cold ");
                    break;

                    case season.Rainy:
                    Console.WriteLine("It is rainy");
                    break;

                    case season.Spring:
                    Console.WriteLine("It is beautiful ");
                    break;

                default:
                    Console.WriteLine("Unknown");
                    break;






            }

        }
    }
}
