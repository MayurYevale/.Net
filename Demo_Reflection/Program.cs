using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Demo_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"C:\Users\mayur\OneDrive\Desktop\.Net\demo_second\bin\Debug\demo_second.exe");
            // asm contains metadata of exe file
            Type[] arr = asm.GetTypes();

            foreach (Type t in arr)
            {
                Console.WriteLine(t.FullName);  
            }
        }
    }
}
