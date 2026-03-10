using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Lets you add a default implementation to an interface member, making it optional to implement
    internal class DefaultInterfaceMembers
    {
        public static void Run()
        {
            // Default implementations must be called explicitly through the interface
            ((ILogger)new Logger()).Log("message");

        }
    }

    interface ILogger
    {
        // This means that you can add a member to an interface without breaking implementations
        void Log (string text) => Console.WriteLine (text);

        // Interfaces can also define static members (including fields), which can be accessed from code inside default implementations
        // Or from outside the interface unless restricted via an accessibility modifier on the static interface member (such as private, protected, or internal)
        static string Prefix = "";
    }

    class Logger : ILogger
    {

    }
}
