using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Three new patterns, nistky for the benefit of switch statements/expressions
    internal class TuplePositionalPropertyPatterns
    {
        public static void Run()
        {
            // Tuple patterns let you switch on multiple values
            int cardNumber = 12; string suite = "spades";
            string cardName = (cardNumber, suite) switch
            {
                (13, "spades") => "King of spades",
                (13, "clubs") => "King of clubs",
                //...
                _ => $"Pip of {suite}"
            };

            // Positional patterns allow a similar syntax for objects that expose a deconstructor
            // Property patterns let you match on an object's properties
            // You can use all of the patterns both in siwtches and with the is operator

            Object obj = new Object();
            if(obj is string { Length: 4 }) // Property pattern test whether obj is a with a length of 4
            {

            }

        }
    }
}
