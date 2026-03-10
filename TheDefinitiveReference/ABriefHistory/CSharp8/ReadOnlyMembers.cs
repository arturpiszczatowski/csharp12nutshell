using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Readonly modifier to a struct's functions ensures that if the function attempts to modify any field, a compile-time error is generated
    internal class ReadOnlyMembers
    {
        // If a readonly function calls a non-readonly function, the compiler generates a warning 
        // (and defensively copies a struct to avoid the possibility of a mutation)
        public static void Run()
        {

        }
        
    }

    struct Point
    {
        public int X, Y;
        public readonly void ResetX() => X.ToString(); // X = 0; would be an Error!
    }
}
