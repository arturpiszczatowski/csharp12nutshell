using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Nullable value types bring nullability to value types
    // Nullable reference types do the opposite and bring (a degree of) non-nullability to reference types
    // The purpose is helping to avoid NullReferenceExceptions
    // They introduce a level of safte that's enforced purely by the compiler in the form of warnings or errors when it detects code that's at risk of generating NullReferenceException
    internal class NullableReferenceTypes
    {
        public static void Run()
        {
            // Nullable reference types can be enabled either at the project level (via the Nullable element in the .csproj project file)
            // or in code (via the #nullable directive)
            // After it's enabled, the compiler makes non-nullability the default
            // if you want reference type to accept nulls, you must apply the ? suffix to indicate a nullable reference type

#nullable enable // Enable nullable reference types from this point on

            string s1 = null; // Generates a compiler warning! (s1 is non-nullable)
            string? s2 = null; // OK: s2 is nullable reference type

            // Uninitialized fields also generate a warning (if the type is not marked as nullable)
            // as does dereferencing a nullable reference type, if the compiler thinks a NullReferenceException might occur
        }

        static void Foo(string? s) => Console.WriteLine(s.Length); // Warning (.Length)
        // To remove the warning, you can use the null-forgiving operator (!)
        static void FooForgiving(string? s) => Console.WriteLine(s!.Length);
    }
}
