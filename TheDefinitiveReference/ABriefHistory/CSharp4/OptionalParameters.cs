using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp4
{
    // Allow functions to specify default parameter values so that callers can omit arguments
    // Name arguments allow a function caller to identify an argument by name rather than position
    internal class OptionalParameters
    {
        public static void Run()
        {
            Log("System started");
            Log("File missing", "WARNING");
            Log("Debug info", includeTimestamp: true); // Named arguments allow to skip optional parameters and specify only desired ones
        }
        
        // Before optional parameters, you needed method overloads. Optional parameters eliminate that boilerplate
        static void Log(string message, string level = "INFO", bool includeTimestamp = true) {
            if (includeTimestamp)
            {
                Console.WriteLine($"{DateTime.Now}: [{level} {message}]");
            } else
            {
                Console.WriteLine($"[{level}] {message}");
            }
        }
    }
}
