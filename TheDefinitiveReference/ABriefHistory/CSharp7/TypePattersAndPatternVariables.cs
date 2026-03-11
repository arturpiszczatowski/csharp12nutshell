using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    internal class TypePattersAndPatternVariables
    {
        public static void Run()
        {
            object x = "I'm a string";
            Foo(x);
            Foo(123);

            // Switch statement also supports type patterns, so you can switch on type as well as constants
            // You can specify conditions with a 'when' clause and also switch on the null values

            switch (x)
            {
                case int i:
                    Console.WriteLine("It's an int!");
                    break;
                case string s:
                    Console.WriteLine(s.Length); // we can use the s variable
                    break;
                case bool b when b == true: // matches only when b is true
                    Console.WriteLine("True");
                    break;
                case null:
                    Console.WriteLine("Nothing");
                    break;
            }
        }

        // You can introduce variables on the fly with the 'is' operator
        // These are called pattern variables

        static void Foo(object x)
        {
            if (x is string s)
            {
                Console.WriteLine(s.Length);
            }
        }
    }
}
