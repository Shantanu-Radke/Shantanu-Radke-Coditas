using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_and_this
{
    public class point
    {
        int x;
        int y;

        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void m1()
        {
            Console.WriteLine("Coordinate x = " + x +" Coordinate y " + y );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            point p = new point(20, 30);
            p.m1();
        }
    }
}
