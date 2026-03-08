using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp9
{
    // Special kind of class that's designed to work well with immutable data
    // The compiler implements records as classes at runtime
    internal class Records
    {
        public static void Run()
        {
            // Its most special feature is that it supports nondestructive mutation via a new keyword (with)
            Point p1 = new Point(2, 3);
            Point p2 = p1 with { Y = 4 };
            Console.WriteLine(p2);
        }
    }

    // A record can also eliminate the boilerplate code of defining properties and writing a constructor and deconstrutor
    record Point{
        public Point(double x, double y) => (X, Y) = (x, y);
        public double X { get; init; }
        public double Y { get; init; }

    }

    // We can replace our Point record definition with the following, without loss of functionality
    // Like tuples, records exhibit structural equality by default
    // Records can subclass other records, and can include the same constructs that classes can include
    record PointSimple(double X, double Y);
}
