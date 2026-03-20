using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Implicitly typed local variables ('var') keyword let you omit the variable type in a declaration statement, allowing the compiler to infer it
    // This reduces clutter as well as allowing anonymous types - which are simple classes created on the fly that are commonly used in the final output of LINQ queries
    // You can also implicitly type arrays
    internal class ImplicitlyTypedLocalVariables
    {
        public static void Run()
        {
            // Basic usage
            // Var is still statically typed, not dynamic
            // You must initialize it (var x; wouldn't work) because compiler needs value to infer the type (can't be 'var x = null' either)
            // Cannot change type (var x=10; x="string";). Still strongly typed.
            var number = 10; // int
            var text = "hello"; // string
            var pi = 3.14; // double

            Console.WriteLine(number.GetType());
            Console.WriteLine(text.GetType());
            Console.WriteLine(pi.GetType());

            // Arrays
            var numbers = new[] { 1, 2, 3, 4 }; // int[]

            // LINQ (very common use case)
            // LINQ often produces complex types
            var evens = numbers.Where(x => x % 2 == 0);

            foreach (var n in evens)
            {
                Console.WriteLine(n);
            }

            // Anonymous types (MAIN reason var exists)
            // There is no way to write the type explicitly, so var is required
            var person = new { Name = "Alice", Age = 30 };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

        // var vs dynamic
        // var => compile-time type checking | dynamic => runtim type checking
        // var => strong type safety | dynamic => weak type safety
        // var => convenience use case | dynamic => flexibility use case
    }
}
