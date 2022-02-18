using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{
    class MethodOverloading
    {
        public void show(int x)
        {
            Console.WriteLine("Integer");
        }

        public void show(string x)
        {
            Console.WriteLine("string");
        }

        public void show(double x)
        {
            Console.WriteLine("doyble");
        }
        static void Main(string[] args)
        {
            MethodOverloading md = new MethodOverloading();
            md.show(34);
            md.show(25.36);
           md.show("dfj");

            Console.ReadLine();
        }
    }
}
