using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp6
{
    // The nameof operator returns the name of a vairable, type, or other symbol as a string
    // This avoids breaking code when you rename a symbol in Visual Studio
    internal class NameOf
    {
        public static void Run()
        {
            int capacity = 123;
            string x = nameof(capacity); // x is "capacity"
            string y = nameof(Uri.Host); // y is "Host"
        }
    }
}
