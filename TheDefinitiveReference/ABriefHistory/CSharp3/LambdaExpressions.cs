using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Lambda expressions are miniature functions created by compiler on the fly
    // They are particularly useful in "fluent" LINQ queries
    internal class LambdaExpressions
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Basic lamda
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(4));

            // Lambda with multiple parameters
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(3, 5));

            // Lambda in LINQ (most common use case)
            var evens = numbers.Where(x => x % 2 == 0);

            foreach(var n  in evens) { Console.WriteLine(n); }

            // Projection (transforming data)
            var squares = numbers.Select(x => x * x);
            foreach (var sq in squares) { Console.WriteLine(sq); }


            // x => x * x means: input x -> return x * x

            // Lambdas are compiled into delegates
            // Func<int, int> square = x => x * x
            // becomes something like:
            // Func<int, int> square = new Func<int, int>(SquareMethod);

            // Single parameter
            Func<int, int> y = x => x * 2;
            // Multiple parameters
            Func<int, int, int> s = (a, b) => a + b;
            // Statement body
            Func<int, int> b = f =>
            {
                int y = f * 2;
                return y;
            };

            // Before C#3 you had to use anonymous methods like:
            // numbers.Where(delegate(int x) { return x % 2 == 0 });
        }
    }
}
