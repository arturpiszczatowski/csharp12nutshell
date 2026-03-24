using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("MyTests")]

// If assemblies are strong-anemd, you must include the public key:
//[assembly: InternalsVisibleTo("MyTests, PublicKey=...")]

namespace ABriefHistory.CSharp2
{
    // Friend assemblies allow one assembly to access the internal members of another.
    // This is done using the InternalsVisibleTo attribute and is commonly used for testing.
    internal class FriendAssemblies
    {
        // MainApp.dll Tests.dll
        // Tests need access to internal logic without making it public
        // internal = visible inside assembly
        // friend assembly = extends that visibility
        public static void Run()
        {

        }
    }
}
