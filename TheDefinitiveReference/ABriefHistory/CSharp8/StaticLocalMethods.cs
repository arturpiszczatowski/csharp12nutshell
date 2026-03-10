using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Adding the static modifier to a local method prevents it from seeing the local variables and parameters of the enclosing method
    // Helps to reduce coupling and enables the local method to delcare variables as it pleases, without risk of colliding with those in the containing method
    internal class StaticLocalMethods
    {
        public static void Run()
        {
            int multiplier = 2;


            // Is fine
            int Multiply(int x)
            {
                return x * multiplier;
            }

            // Can't see multiplier variable
            static int Divide(int x)
            {
                //return x / multiplier;
                return x / 2;
            }

            Console.WriteLine(Multiply(5));

            // Correct way to pass values
            static int MultiplyStatic(int x, int m)
            {
                return x * m;
            }

            Console.WriteLine(MultiplyStatic(5, multiplier));



        }

        // Factorial
        public static int Factorial(int n)
        {
            // This helper method cannot accidentally depend on out variables
            static int Calc(int x)
            {
                return x <= 1 ? 1 : x * Calc(x - 1);
            }

            return Calc(n); ;
        }
    }
}
