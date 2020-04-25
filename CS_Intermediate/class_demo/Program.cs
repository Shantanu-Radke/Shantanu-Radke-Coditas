using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_demo
{
    public class Person
    {

        public String name;
        

        public void introduce(string name1)
        {
            Console.WriteLine("Hello " + name + " I am " + name1);
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.name = "Stark";
            p.introduce("Mosh");
        }
    }
}
