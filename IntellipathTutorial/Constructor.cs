using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{
    class ConstructorDemo
    {

        // static constructor
        static ConstructorDemo()
        {
            Console.WriteLine("static called");
        }

      public   ConstructorDemo()
        {
            Console.WriteLine("instance called");
        }
        static void Main(string[] args)
        {
            ConstructorDemo dt  = new ConstructorDemo();    

            Console.ReadLine();
        }
     }
}
