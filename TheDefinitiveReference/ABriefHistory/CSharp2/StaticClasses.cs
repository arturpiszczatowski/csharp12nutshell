using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp2
{
    // Static classes cannot be instantiated and can only contain static members.
    // They are commonly used for utility methods and helper functionality.
    // Normal class → blueprint for objects
    // Static class → toolbox of functions
    internal class StaticClasses
    {
        // They are used for:
        // 1) Utility methods
        // 2) Helper functions
        // 3) Grouping related functionality
        public static void Run()
        {
            MathUtils.PrintSquare(5);

            // compile-time error
            // MathUtils m = new MathUtils();

            // E.g. Console and Math are static classes
            Console.WriteLine("Static class and method");
            Math.Sqrt(4);
        }
    }

    // Rules:
    // 1) Cannot be instantiated
    // 2) Cannot have instance members
    // 3) Cannot have constructors (except static constructor)
    // 4) Are implicitly sealed (cannot be inherited)
    public static class MathUtils
    {
        // Static constructor
        static MathUtils()
        {
            // Runs first time the class is accessed
            Console.WriteLine("Initialized once");
        }
        // Static class = container for methods, not objects
        public static void PrintSquare(int n)
        {
            Console.WriteLine(n * n);
        }
        // Extension methods must live in a:
        public static class Extensions { }
    }
}
