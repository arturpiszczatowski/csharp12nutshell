using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Expression trees represent lambda expressions as data structures (trees).
    // Instead of compiled code, they describe the structure of the expression,
    // allowing it to be inspected, modified, or translated (e.g., into SQL).
    // This is how LINQ providers (like Entity Framework) execute queries remotely.
    internal class ExpressionTrees
    {
        public static void Run()
        {
            // Normal lambda
            // This is comppiled code
            // You can run it, but you cannot inspect it
            Func<int, bool> func = x => x > 5;

            // Expression tree
            // This is data (a tree structure)
            // You can inspect it, modify it, translate it
            Expression<Func<int, bool>> expr = x => x > 5;

            Console.WriteLine(expr); // x => (x > 5)
            Console.WriteLine(expr.Body); // (x > 5)

            // Break it down
            // We cast it to BinaryExpression because only then can we access the scrutcture of (x > 5) => left, operator, right
            var body = (BinaryExpression)expr.Body;
            Console.WriteLine(body.Left); // x
            Console.WriteLine(body.Right); // 5
            Console.WriteLine(body.NodeType); // GreaterThan

            // The lambda: x => x > 5
            // becomes a tree like
            /*
                  >
                 / \
                x   5 
            */
            // This is why it's called an expression tree


            // Expression can become Func
            // Func can't become Expression
            var funcFromExpr = expr.Compile();
            Console.WriteLine(funcFromExpr(10)); // true

            Expression<Func<string, bool>> expres = s => s.StartsWith("A"); // Database provider might trasnlate this into: WHERE Name LIKE 'A%'

        }

        public static void Elaboration()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Normal LINQ
            // Uses Func<int, bool>
            // Runs in memory
            var n = numbers.Where(x => x > 5);

            // LINQ to SQL / Entity Framework
            // Uses Expression<Func<User, bool>>
            // Not executed directly

            // var u = db.Users.Where(x => x.Age > 18);

            // Instead :
            /*
                x => x.Age > 18
                ↓
                expression tree
                ↓
                translated into SQL
                ↓
                SELECT * FROM Users WHERE Age > 18
            */

            //                          Func vs Expression
            // FUNC is a COMPILED CODE         || EXPRESSION is a DATA (TREE)
            // FUNC can execute                || EXPRESSION needs Compile()
            // FUNC can't be inspected         || EXPRESSION can be inspected
            // FUNC is used in LINQ to Objects || EXPRESSION is used in LINQ to SQL / EF            

        }


    }
}
