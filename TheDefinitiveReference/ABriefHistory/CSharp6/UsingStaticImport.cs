using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ABriefHistory.CSharp6
{
    // The using static directrive lets you import all the static members of a type so that you can use those members unqalified
    internal class UsingStaticImport
    {
        public static void Run()
        {
            WriteLine("WriteLine instead of Console.WriteLine");
        }
    }
}
