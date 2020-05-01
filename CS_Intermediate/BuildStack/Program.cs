using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuildStack
{   
    //This class contains the methods required for stack peration.
    public class Mystack
    {

      private List<Object> stk = new List<Object>();
      int LastIndex = -1;
        
        
        //this method take any type of object and display it
        public void push(Object a)
        {


            stk.Add(a); LastIndex++;
            Console.WriteLine(a + " Added\n");
            
        }


        
        
        //this method removes thelatest added element in stack
        //if stack is empty then throws exception
        public void pop()
        {

            try
            {
                if (!stk.Any())
                {
                    throw new InvalidOperationException();
                }

                else
                {
                    
                    Console.WriteLine( stk[LastIndex] + " Popped\n");
                    stk.Remove(LastIndex);
                    LastIndex--;
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Operation ");
            }

        }



        //As this method is called stack is emptied
        public void clear()
        {
            stk.Clear();
            Console.WriteLine("Stack Emptied");

        }

       
    }






    class Program
    {
        static void Main(string[] args)
        {
           
            var m = new Mystack();

            
            m.push(1);
            m.push('a');
            m.push("third");

            m.pop();
            m.pop();

            m.clear();

           
            
            
            
        }
    }
}
