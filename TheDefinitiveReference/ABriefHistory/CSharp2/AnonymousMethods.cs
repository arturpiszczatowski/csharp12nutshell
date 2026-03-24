using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp2
{
    // Anonymous methods allow defining inline methods using the 'delegate' keyword.
    // They were the predecessor to lambda expressions and are now mostly replaced by them.
    internal class AnonymousMethods
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Anonymous method
            numbers.ForEach(delegate (int x)
            {
                Console.WriteLine(x);
            }) ;

            // Equivalent with lambda
            numbers.ForEach(x => Console.WriteLine(x));

            // Assigning to a delegate
            Func<int, int> square = delegate (int x)
            {
                return x * x;
            };

            Console.WriteLine(square(5));

            // Anonymous methods can omit parameters if unused
            Action action = delegate
            {
                Console.WriteLine("Hello");
            };
            // Lambdas require
            Action actionL = () => Console.WriteLine("Hello");


            // Captured variables (closures)
            var actions = new List<Action>();
            for (int i = 0; i < 3; i++)
            {
                // Fix (manual capture)
                // int copy = i;
                actions.Add(delegate
                {
                    // Console.WriteLine(copy);
                    Console.WriteLine(i);
                });
            }

            foreach (var act in actions)
                act();
            // output: 3 3 3 not 0 1 2
            // because variable i is SHARED ACROSS ALL ITERATIONS
            // by the time they run i = 3

            // Same issue with lambdas
            for (int i = 0;i < 3; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }
            // Same result: 3 3 3 
            // This behavor was fixed for 'foreach' in later C# versions, but not for 'for' loops
            // The compiler creates something like
            /*
            class Closure {
                public int i;
            }
            */
            // The labmda captures the variable, not the value
        }
    }
}
