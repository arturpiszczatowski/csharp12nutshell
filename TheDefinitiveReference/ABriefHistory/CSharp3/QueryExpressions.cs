using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Query expressions provide a SQL-like syntax for writing LINQ queries.
    // They are translated by the compiler into method calls (e.g., Where, Select).
    // They are especially useful when working with multiple sequences, joins, or complex queries.
    internal class QueryExpressions
    {
        // They provide an SQL-like syntax for LINQ queries
        public static void Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Query expression syntax
            var evenQuery = from n in numbers
                            where n % 2 == 0
                            select n;

            Console.WriteLine("Query expression:");
            foreach(var n in evenQuery)
                Console.WriteLine(n);

            // Equivalent method syntax
            var evensMethod = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Method syntax:");
            foreach(var n in evensMethod)
                Console.WriteLine(n);

            var letters = new[] { "A", "B", "C" };

            // Multiple variables
            var combinationsQuery = from n in numbers
                               from l in letters
                               select $"{n}{l}";
            // Equivalent
            var combinationsMethod = numbers.SelectMany(n => letters,
                (n, l) => $"{n}{l}");


            // JOINS
            var people = new[]
            {
                new { Name = "Alice", CityId = 1 },
                new { Name = "Bob", CityId = 2 }
            };
            var cities = new[]
            {
                new { Id = 1, Name = "Warsaw" },
                new { Id = 2, Name = "Paris" }
            };

            var query = from p in people
                        join c in cities on p.CityId equals c.Id
                        select new { p.Name, City = c.Name };

            foreach (var item in query)
                Console.WriteLine($"{item.Name} lives in {item.City}");

            // FROM introduces a range variable (n) => from n in numbers
            // WHERE filters elements => where n % 2 == 0
            // SELECT projects (chooses what to return) => select n
        }
    }
}
