using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp10
{
    // Primarily to improve compiler performance with complex nested lambdas
    internal class LambdaExpressionEnhancments
    {
        public static void Run()
        {
            // 1. Implicit typing (var) is permitted
            // The implicit type for a lambda expression is an Action or Func delegate, so greeter in this case is of type Func<string>
            var greeter = () => "Hello, world";
            // You must explicitly state any parameter types
            var square = (int x) => x * x;

            // 2. Lamda expression can specify ar eturn type
            var sqr = int (int x) => x;

            // 3. You can pass a lambda expression into a method parameter of type 'object', 'Delegate', or 'Expression'
            M1(() => "test"); // Implicitly typed to Func<string>
            M2(() => "test"); // Implicitly type to Func<string>
            M3(() => "test"); // Implicitly type to Expression<Func<string>>

            // 4. You can apply attributes to lambda expression's compile-generated target method (as well as its parameters and return value)
            Action a = [Description("test")] () => { };
        }

        static void M1 (object x) { }
        static void M2 (Delegate x) { }
        static void M3 (Expression x) { }
    }
}
