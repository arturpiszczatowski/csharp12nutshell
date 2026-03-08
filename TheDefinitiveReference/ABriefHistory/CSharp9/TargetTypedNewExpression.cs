using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp9
{
    // When constructing an object C#9 lets you omit the type name when the compiler can infer it unambigously
    // Particularly useful when the variable declaration and initialization are in different parts of your code
    internal class TargetTypedNewExpression
    {
        public static void Run()
        {
            // Used to be like this (duplicating the type on initialization)
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
            System.Text.StringBuilder sb2 = new System.Text.StringBuilder("Test");

            // Now compiler looks at the left side to determine the type
            System.Text.StringBuilder sb3 = new();
            System.Text.StringBuilder sb4 = new("Test");

            MyMethod(new("test")); // new("test") => new StringBuilder("test")
        }
        class Foo
        {
            System.Text.StringBuilder sb;
            public Foo(string initialValue) => sb = new(initialValue);
        }
        static void MyMethod(System.Text.StringBuilder sb) { }
    }
}
