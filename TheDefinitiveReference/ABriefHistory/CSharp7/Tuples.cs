using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    // Provide a simple way to store a set of related values
    internal class Tuples
    {
        public static void Run()
        {
            var bob = ("Bob", 23);
            Console.WriteLine(bob.Item1);
            Console.WriteLine(bob.Item2);

            // Tuple elements can be named
            var tuple = (name: "Bob", age: 23);
            Console.WriteLine(tuple.name);
            Console.WriteLine(tuple.age);

            var pos = GetFilePostiotion();
            Console.WriteLine(pos.row);
            Console.WriteLine(pos.column);

            // Tuples implicitly support the deconstruction pattern, so you can easily deconstruct them into individual variables
            (int row, int column) = GetFilePostiotion();
            Console.WriteLine(row);
            Console.WriteLine(column);
        }

        // With tuples, functions can return multiple values without resorting to out parameters or extra type baggage
        static (int row, int column) GetFilePostiotion() => (3, 10);
    }
}
