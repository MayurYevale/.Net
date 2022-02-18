using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellipathTutorial
{
    class Cricket
    {
        static int score;
        // static is irrespective of objects 

        public void Incr(int x)
        {
            score += x;
        }
        static void Main(string[] args)
        {
            Cricket.score = 100;
            Cricket fb = new Cricket();
          
            fb.Incr(1); 
            fb.Incr(2); 
                fb.Incr(3);
                fb.Incr(4);
            Console.WriteLine("Total Score is : "+score);
            Console.ReadLine();
        }

     }
 }
