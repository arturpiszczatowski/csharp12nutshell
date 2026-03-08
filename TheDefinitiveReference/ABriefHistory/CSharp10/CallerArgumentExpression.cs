using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp10
{

    // A method parameter to which you apply the [CallerArgumentExpression] attribute captures an arugment expression from the call site
    internal class CallerArgumentExpression
    {
        public static void Run()
        {
            Print(Math.PI * 2);
        }
        
        // It lets a method a capture the exact expression the caller wrote and pass it as a string
        // Instead of receiving the value, the method can also receive the code expression that produced that value
        static void Print(double number, [CallerArgumentExpression("number")] string expr = null) => Console.WriteLine(expr);
    }
}
