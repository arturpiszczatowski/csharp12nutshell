using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp4
{
    // Defers 'binding' - the process of resolving types and members - from compile time and to runtime
    // Is useful in scenarios that would otherwise require complicated reflection code
    // Dynamic binding is also useful when interoperating with dynamic languages and COM components
    internal class DynamicBinding
    {
        public static void Run()
        {
            // Normally C# resolves everything at compile time
            string text = "hello";
            Console.WriteLine(text.Length); // The compiler already knows "text -> string" and "Length -> property on string"

            // With 'dynamic' the compiler does not check the type
            // The runtime resolves members when the code runs
            // Dynamic shifts errors from compile time to runtime
            dynamic value = "hello";
            Console.WriteLine(value.Length); // resolved at runtime

            value = 10;
            Console.WriteLine(value + 5); // runtime decides operation


            // Without dynamic you'd need reflection
            object obj = "hello";

            var lengthProperty = obj.GetType().GetProperty("length");
            Console.WriteLine(lengthProperty.GetValue(obj));

            // Common scenarios:
            // JSON libraries (older ones)
            // Office / COM automation
        }
    }
}
