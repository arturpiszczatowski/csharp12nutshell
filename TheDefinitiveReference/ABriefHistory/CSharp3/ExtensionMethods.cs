using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Extension methods allow adding new methods to existing types without modifying them.
    // They are static methods that can be called like instance methods.
    // LINQ is built entirely on extension methods.
    internal class ExtensionMethods
    {
        // They must:
        // 1) Be in a static class
        // 2) Be a static method
        // 3) Have 'this' before the first parameter
        public static void Run()
        {
            string text = "hello";

            // Looks like an instance method, but it's actually static
            string result = text.Capitalize(); // It's actually compiled as: StringExtensions.Capitalize(text);
            Console.WriteLine(result);
        }
    }

    // Extension methods must be in a static class
    public static class StringExtensions
    {
        // 'this string' makes it an extension method
        public static string Capitalize(this string input) // this means: "extend the string type with this method"
        {
            if(string.IsNullOrEmpty(input)) return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
