using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{   
    class Data
    {
        public void Mayur()
        {
            Console.WriteLine("in mayur");
        }

        internal void Shubham()
        {
            Console.WriteLine("in shubham");
        }

        private void Manish()
        {
            Console.WriteLine("in manish");
        }
    }

  
    class FirstDemo
    {
        int Temp, temp2;

        public void SampleFunc()
        {
            Console.WriteLine("sample fun called");
        }
        static void Main(string[] args)
        {
            Data data = new Data(); 
            data.Mayur();
            data.Shubham();
            //    data.Manish();  //as it is private

          FirstDemo firstDemo = new FirstDemo();
            firstDemo.SampleFunc();

            firstDemo.temp2 = 3;
           
            Console.ReadLine();
            
        }

       
    }
}
