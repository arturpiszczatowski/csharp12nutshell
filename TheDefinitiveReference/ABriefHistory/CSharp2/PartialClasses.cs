using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp2
{
    // Partial classes allow splitting a class definition across multiple files or parts.
    // The compiler combines all parts into a single class.
    // Commonly used with generated code to separate auto-generated and manual logic.
    internal class PartialClasses
    {
        // Rules
        // Partial classes:
        // 1) Have the same name
        // 2) Are in the same namespace
        // 3) Are all marked 'partial'
        // 4) Are merged at compile time
        public static void Run()
        {
            var p = new Person();
            p.SayHello();
            p.SayGoodbye();
        }
    }

    // Part 1
    public partial class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

    // Part 2
    public partial class Person
    {
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
