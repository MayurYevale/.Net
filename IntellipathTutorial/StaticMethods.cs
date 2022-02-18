using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{
    class StaticMethods
    {
        class Data
        {
            public void Show()
            {
                Console.WriteLine("Show method , non static");
            }

            public static void  Display()
            {
                Console.WriteLine("Display method , STATIC METHOD");
            }
        }
        static void Main(string[] args)
        {

            Data.Display();
           Data data = new Data();  
            data.Show();
           // data.Display(); // as it is static

             

            Console.ReadLine();
        }
    }
}
