/*Exercise 1: Design a Stopwatch 

Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It shouldprovide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be avalue in TimeSpan. Display the duration on the console. 

We should also be able to use a stopwatch multiple times. So we may start and stop it and thenstart and stop it again. Make sure the duration value each time is calculated properly. 

We should not be able to start a stopwatch twice in a row (because that may overwrite the initialstart time). So the class should throw an InvalidOperationException if its started twice. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch1
{
    public class StopWatch
    {
        DateTime _start,_stop;
        public void start()
        {
            _start = DateTime.Now;
        }

        public TimeSpan stop()
        {
            _stop = DateTime.Now;

           return ( _stop - _start) ;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
           int check=1,StartOrStop;

           var sw = new StopWatch();

            while(check != 2)
            {
                Console.WriteLine("Press 1 to start");
                StartOrStop = Convert.ToInt16(Console.ReadLine());

                
                if (StartOrStop != 1 || StartOrStop != 0)
                {
                    Console.WriteLine("You Entered wrong choice");
                    break;
                }

                if (StartOrStop == 1)
                {
                    sw.start();
                }

                Console.WriteLine("Press 0 to start");
                StartOrStop = Convert.ToInt16(Console.ReadLine());

                if (StartOrStop == 0)
                {
                    Console.WriteLine("Duration :" + sw.stop());
                }

                Console.WriteLine("Press 1 to start again or 2 to exit");
                check = Convert.ToInt16(Console.ReadLine());

            }



        }
    }
}
