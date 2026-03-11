using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    internal class OutVariablesAndDiscards
    {
        public static void Run()
        {
            // You can declare out variables on the fly 
            bool successful = int.TryParse("123", out int result);

            // When calling a method with multiple out parameters, you can discard ones you're uninterested in with the underscore characters
            // It must output values here, but _ says you don't care about storing it
            SomeBigMethod(out _, out _, out _, out int x, out _);
            Console.WriteLine(x);
        }

        public static void SomeBigMethod(out int a, out int b, out int c,out int d, out int e) {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }
}
