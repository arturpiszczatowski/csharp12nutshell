using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    internal class NumericLiteralImprovements
    {
        public static void Run()
        {
            // Numeric literals can include underscores to improve readability
            // These are called digit separators and are ignored by the compiler
            int million = 1_000_000;

            // Binary literals can be specified with the 0b prefix
            var b = 0b1010_1011_1100_1101_1110_1111;
        }
    }
}
