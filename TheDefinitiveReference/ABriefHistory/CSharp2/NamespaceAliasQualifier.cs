using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using alias
using Sys = System;

// Resolving two identical class names
using A = FirstNameSpace;
using B = SecondNamespace;

namespace ABriefHistory.CSharp2
{
    // Namespace alias qualifiers allow disambiguating types with the same name.
    // You can use 'global::' to refer to the root namespace or define aliases with 'using'.
    // Alias = give a namespace a nickname
    // global:: = force lookup from root
    internal class NamespaceAliasQualifier
    {
        // It exists to solve:
        // 1) Name collisions
        // 2) Ambiguous references
        // 3) large projects with many libraries
        public static void Run()
        {
            // Refers to OUR Console class
            Console2.WriteLine("My Csonsole");

            // Refers to System.Console
            // global:: means - start from the root namespace (useful when something shadoews a namespace)
            global::System.Console.WriteLine("System Console");

            Sys.Console.WriteLine("Using alias");

            A.MyClass a = new A.MyClass();
            B.MyClass b = new B.MyClass();

        }
    }

    // Custom Console class (conflicts with System.Console)
    class Console2 // Added '2' to prevent ambigouity in other classes
    {
        public static void WriteLine(string message)
        {
            System.Console.WriteLine($"Custom: {message}");
        }
    }
}

namespace FirstNameSpace
{
    class MyClass { }
}

namespace SecondNamespace
{
    class MyClass { }
}
