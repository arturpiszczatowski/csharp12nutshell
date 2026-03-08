using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp9
{
    internal class PatternMatchingImprovements
    {
        public static void Run()
        {
            var obj = new Object();
            // The not combinator can be used with the type pattern to test whether and object is (not) a type
            if(obj is not string)
            {
                Console.WriteLine($"{obj.ToString()} is not a string");
            }
            Console.WriteLine(GetWeightCategory(21m));
            Console.WriteLine(IsVowel('b') ? "b is a vowel" : "b is not a vowel");
            Console.WriteLine(IsLetter('1') ? "1 is a letter" : "1 is not a letter");

        }

        // The relational pattern allows the <, >, <=, and >= operators to appear in patterns
        static string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            _ => "obese"
        };

        // With pattern combinators you can combine patters via three new keywords (and, or, not)
        static bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';

        // Boolean version:
        // c == 'a' || c == 'e' || c == 'i'
        // Pattern version:
        // c is 'a' or 'e' or 'i'

        static bool IsLetter(char c) => c is >= 'a' and <= 'z'
            or >= 'A' and <= 'Z';
    }
    
}
