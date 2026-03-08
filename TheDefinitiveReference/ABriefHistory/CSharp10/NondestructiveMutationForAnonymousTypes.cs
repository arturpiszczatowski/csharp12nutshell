using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp10
{
    // C#9 introduced the 'with' keyword to perform nondestructive mutation on records
    // C#10 the 'with' keywords also works with anyonymous types
    internal class NondestructiveMutationForAnonymousTypes
    {
        public static void Run()
        {
            var a1 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };
            Console.WriteLine(a1);
            var a2 = a1 with { E = 10 };
            Console.WriteLine(a2);
        }
        
    }
}
