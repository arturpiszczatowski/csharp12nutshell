using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp2
{
    // Nullable value types allow value types (int, bool, DateTime, etc.)
    // to represent null using the '?' suffix.
    // Internally, this is implemented as Nullable<T>.
    internal class NullableValueTypes
    {
        public static void Run()
        {
            // Value types (like int, bool, DateTime) cannot be null
            // int x = null; is not allowed
            // But sometimes you need no value (e.g. database field that can be empty)
            int? x = null; // int OR null

            int? a = null; 
            int? b = 10; // Same as => Nullable<int> b = new Nullable<int>(10);
            Console.WriteLine(a.HasValue); // false
            Console.WriteLine(b.HasValue); // true

            // Safe access
            Console.WriteLine(a ?? 0); // 0 (default if null)

            // Nullable arithemtic
            // null + anything = null
            int? sum = a + b;
            Console.WriteLine(sum); // null
        }
    }
}
