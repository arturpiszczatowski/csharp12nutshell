using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp9
{
    // Allows to create immutable (read-only) types that can be populated via an object initializer instead of a constructor
    // Helps to avoid the antipattern of constructors that accept a large number of optional paramters
    // Also allow for nondestructive mutation when used in records
    internal class InitOnlySetters
    {
        public static void Run()
        {
            var foo = new Foo() { Id = 1 };
        }
    }

    class Foo()
    {
        // This behaves like a read-only property, except that it can also be set via an object initializer
        public int Id { get; init; }
    }
}
