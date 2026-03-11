using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    // A local method is a method declared within another function
    internal class LocalMethods
    {
        public static void Run()
        {
            WriteCubes();
        }

        static void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));

            // They are visible only to the containing functions and can capture local variables in the same way that lambda expressions do
            int Cube(int value) => value * value * value;
        }
    }
}
