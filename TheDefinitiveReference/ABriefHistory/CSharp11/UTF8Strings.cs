using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp11
{
    // Used for high-performance byte processing
    internal class UTF8Strings
    {
        public static void Run()
        {
            // You can create string literals encoded in UTF-8 rather than UTF-16
            // This feature is intended for advanced scenarios such as the low-level handling of JSON text in performance hotspots

            ReadOnlySpan<byte> utf8 = "ab→cd"u8; // Arrow symbol consumes 3 bytes
            Console.WriteLine(utf8.Length);

            // Normal string 
            // UTF-16
            // | a | b | → | c | d |

            // ReadOnlySpan<byte>
            // | 61 | 62 | E2 | 86 | 92 | 63 | 64 |
        }
    }
}
