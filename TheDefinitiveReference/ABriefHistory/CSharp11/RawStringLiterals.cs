using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp11
{
    internal class RawStringLiterals
    {
        public static void Run()
        {
            // Wrapping a string in three or more quote characters creates a raw string literal
            // They can contain almost any character sequence without escaping or doubling up
            string raw = """<file path="c:\temp\test.txt"></file>""";

            // String literals can be multiline and permit interpolation via the $ prefix
            string multiLineRaw = $"""
            Line 1
            Line 2
            The date and time is {DateTime.Now}
            """;

            // Using two (or more) $ characters in a raw string literal prefix changes the interpolation sequence from one brace to two (or more) braces, allowing you to include braces in the string itself
            string timestamp = $$"""{ "TimeStamp": "{{DateTime.Now}}" }""";

            Console.WriteLine(raw);
            Console.WriteLine(multiLineRaw);
            Console.WriteLine(timestamp);

        }
    }
}
