using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    // Prior to C#7 throw was always a statement
    // Now it can also appear as an expression in expression-bodied functions
    internal class ThrowExpressions
    {
        public static void Run()
        {
            Console.WriteLine(Capitalize("chase"));
            Capitalize(null);
        }

        public static string Foo() => throw new NotImplementedException();

        // Now a throw expression can also appear in a ternary conditional expression
        public static string Capitalize(string value) =>
            value == null ? throw new ArgumentException(nameof(value)) :
            value == "" ? "" :
            char.ToUpper(value[0]) + value.Substring(1);
    }

    /*
    Example of an argument validation

        Very common pattern:

        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        Before C# 7 you had to write:

        public Person(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
        
            Name = name;
        }

    Because the ternary operator (?:) requires EXPRESSIONS, and throw used to be a STATEMENT
    */
}
