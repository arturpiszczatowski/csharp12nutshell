using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.C_12
{
    internal class DefaultLambdaParameters
    {
        public static void Run()
        {
            // Lamda expression can now define parameters with default values (just as oridinary methods)
            void Print (string message = "I'm a default message") => Console.WriteLine (message);

            Print();
            Print("I have a value");
        }
    }
}
