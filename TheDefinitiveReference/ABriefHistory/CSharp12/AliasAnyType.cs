using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Alias of a simple or generic type via the using directive
using ListOfInt = System.Collections.Generic.List<int>;

// Now this approach works with other kinds of types too (such as arrays and tuples)
using NumberList = double[];
using Point = (int X, int Y);

namespace ABriefHistory.C_12
{
    internal class AliasAnyType
    {
        public static void Run()
        {
            var list = new ListOfInt();

            NumberList numbers = [2.5, 3.5];
            Point p = (3, 4);
        }
    }
}
