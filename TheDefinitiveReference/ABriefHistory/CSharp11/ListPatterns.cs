using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp11
{
    // Match a series of elements in square brackets, and work with any collection type that is countable and indexable
    internal class ListPatterns
    {
        public static void Run()
        {
            int[] numbers = { 0, 1, 2, 3, 4 };
            Console.WriteLine(numbers is [0, 1, 2, 3, 4]); // true

            // _ matches a single element of any value
            // .. match zero or more elements (a slice)
            Console.WriteLine(numbers is [_, 1, .., 4]); // true

            // A slice can be followe by the var pattern

        }
    }
}
