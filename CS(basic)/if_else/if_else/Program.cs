using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
   

    class Program
    {
        public enum season
        {
            summer,
            rainy,
            winter,
            spring


        }

        static void Main(string[] args)
        {
            var ThisSeason = season.summer;

            switch (ThisSeason)
            {
                case season.summer:
                    Console.WriteLine("This is hot");
                    break;
                case season.winter:
                    Console.WriteLine("This is cold");
                    break;
                case season.spring:
                    Console.WriteLine("This is beautifull");
                    break;
                case season.rainy:
                    Console.WriteLine("This is rainy");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;




            }

        }
    }
}
