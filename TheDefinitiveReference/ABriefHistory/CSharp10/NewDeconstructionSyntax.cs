using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp10
{
    // C#7 introduced the deconstrution syntax for tuples (or any type with Deconstruct method)
    // C#10 takes this syntax further, letting you mix assignment and declaration in the same deconstruction
    internal class NewDeconstructionSyntax
    {
        public static void Run()
        {
            var point = (3, 4);
            double x = 0;
            (x, double y) = point;

            // Before you had to choose either to declare all variables
            (int a, int b) = point;
            // or use existing variables
            int c;
            int d;
            (c, d) = point;

        }
    }
}
