using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{
    static class Test
    {
        public static void Greet()
        {
            Console.WriteLine("hello");
        }

        //public void Show()
        //{// non static method
        //    // not allowed as class is static 
        //}
    }
    class StaticClass
    {
        static void Main(string[] args)
        {
            Test.Greet();
         //   Test t= new Test(); 

        }
    }
}
