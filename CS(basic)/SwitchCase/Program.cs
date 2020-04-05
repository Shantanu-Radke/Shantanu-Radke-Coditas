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
            summer,
            winter,
            rainy,
            spring
        }


        static void Main(string[] args)
        {    
            var ThisSeason=season.summer;

            switch (ThisSeason)
            {
                case season.summer:
                    Console.WriteLine("It is hot ");
                    break;


                    case season.winter:
                    Console.WriteLine("It is cold ");
                    break;

                    case season.rainy:
                    Console.WriteLine("It is rainy");
                    break;

                    case season.spring:
                    Console.WriteLine("It is beautiful ");
                    break;

                default:
                    Console.WriteLine("Unknown");
                    break;






            }

        }
    }
}
