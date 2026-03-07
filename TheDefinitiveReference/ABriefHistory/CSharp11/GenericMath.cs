using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp11
{
    // System.Numerics.INumber<TSelf> interface unifies arithmetic operations across all numeric types
    internal class GenericMath
    {
        public static void Run()
        {
            int intSum = Sum([3, 5, 7]);
            double doubleSum = Sum([3.2, 5.3, 7.1]);
            decimal decimalSum = Sum([3.2m, 5.3m, 7.1m]);

            Console.Write($"""
                { intSum } 
                { doubleSum } 
                { decimalSum } 
                """);
        }

        // Allows generic methods such as the following to be written
        static T Sum<T>(T[] numbers) where T : INumber<T>
        {
            T total = T.Zero;
            foreach(T n in numbers)
            {
                total += n;
            }
            return total;
        }
    }
}
