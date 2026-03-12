using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp6
{
    // C# 6 allows indexer assignments inside object initializers.
    // Any type with an indexer (like Dictionary) can be initialized using [key] = value syntax.
    internal class IndexInitializers
    {
        public static void Run()
        {
            // Each line inside the initializer becomes an index assignment
            // The compiler roughly translates your code into:
            // var dict = new Dictionary<int, string>();
            // dict[3] = "three";
            // dict[10] = "ten";
            var dict = new Dictionary<int, string>()
            {
                [3] = "three",
                [10] = "ten"
            };
            // Before it would be
            // This calls the dictionary’s Add method, e.g dict.Add(3, "three");
            var dict_old = new Dictionary<int, string>()
            {
                {3, "three"},
                {10, "ten"}
            };

            // It matters, because:
            // dict.Add(3,"three");   // throws if key exists
            // dict[3] = "three";     // overwrites if key exists

            // It's commonly used for example in headers initialization
            var headers = new Dictionary<string, string>
            {
                ["Content-Type"] = "application/json",
                ["Accept"] = "application/json"
            };
        }
    }
}
