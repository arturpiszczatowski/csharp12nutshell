using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp6
{
    // Allow methods, properties, operators, and indexers that comprise a single expression to be written more tersely
    internal class ExpressionBodiedFunctions
    {
        public static void Run()
        {
            TimesTwo(2);
            Console.WriteLine(SomeProperty);
        }
        // In the style of a lambda expression
        public static int TimesTwo(int x) => x * 2;
        public static string SomeProperty => "Property value";
    }
}
