using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{

     class Memory
    {

         int n;
        static void Main(string[] args) 
        {
        Memory obj1 = new Memory();
            Memory obj2 = new Memory();
            obj1.n = 34;
            obj2.n = 5;

            Console.WriteLine(obj1.n);

            Console.WriteLine(obj2.n);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("strings");
            string s = "maur", m = "ads", t = "maur";
                Console.WriteLine(s.GetHashCode());
                Console.WriteLine(m.GetHashCode());   
                Console.WriteLine(t.GetHashCode());
            Console.ReadLine();

         }

    }
}
