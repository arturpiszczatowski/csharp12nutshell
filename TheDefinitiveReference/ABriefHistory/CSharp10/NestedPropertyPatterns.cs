using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp10
{
    internal class NestedPropertyPatterns
    {
        public static void Run()
        {
            var obj = new Uri("https://www.linqpad.net");
            if (obj is Uri { Scheme.Length: 5 }) { };

            // Now nested property pattern matching is available the conditional beneath is equivalent the one above
            if(obj is Uri { Scheme: { Length: 5 } }) { };        }
    }
}
