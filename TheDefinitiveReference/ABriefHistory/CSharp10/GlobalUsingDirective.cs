global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using static ABriefHistory.CSharp10.FileScopedNamespaces; // global using directives work with using static

// Projects now support 'implicit global using directives
// if the ImplicitUsings element is set to tru in the project file, the most commonly used namespaces are automatically imported

namespace ABriefHistory.CSharp10
{
    // When you prefix a using directive with a global keyword, it applies the directive to all files in the project
    // e.g globa using System;
    internal class GlobalUsingDirective
    {
        public static void Run() { }
    }
}
