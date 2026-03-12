using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp6
{
    internal class PropertyInitializers
    {
        public static void Run()
        {
            
        }

        // Let you assing an initial value to an automatic property
        public DateTime TimeCreated { get; set; }

        // Initialized properties can also be read-only
        // Read-only properties can also be set in the constructor, making it easier to create immutable (read-only) types
        public DateTime TimeCreatedReadOnly { get; } = DateTime.Now;
    }
}
