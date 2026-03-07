using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.C_12
{
    internal class CollectionExpressions
    {

        public static void Run()
        {
            // Colletion expressions {} => []
            char[] old_array = { 'a', 'e', 'i', 'o', 'u' };
            char[] collection_expression = ['a', 'e', 'i', 'o', 'u'];

            // Adventages:
            // 1. Works wtih other collection types
            List<char> list = ['a', 'e', 'i', 'o', 'u'];
            HashSet<char> set = ['a', 'e', 'i', 'o', 'u'];
            ReadOnlySpan<char> span = ['a', 'e', 'i', 'o', 'u'];

            // 2. They are target-typed - compiler can infer type (e.g calling methods)
            Console.WriteLine("I have a passed argument: " + TargetTyped(old_array));
            Console.WriteLine("I have an infered type: " + TargetTyped(['a', 'e', 'i', 'o', 'u']));


        }

        public static string TargetTyped(char[] array)
        {
            string content = new string(array);
            return content;
        }
    }
}
