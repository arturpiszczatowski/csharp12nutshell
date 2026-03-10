using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    internal class NullCoalescingAssignment
    {
        public static void Run()
        {
            string s = null;

            // The ??= operator assigns a variable only if it's null
            s ??= "Hello World";
            // It's the same as 
            if (s == null) s = "Hello World";

            

        }
    }
}
