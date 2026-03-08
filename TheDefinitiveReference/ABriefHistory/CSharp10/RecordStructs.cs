using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp10
{

    // Records were first introduced in C#9 where they acted as a compiled-enhanced class    
    internal class RecordStructs
    {
        // In C#10 records can also be structs
        // Records structs have much the same features as class structs
        record struct Point (int X, int Y);

        // An exception is that compiler-generated properties on record structs are writable, unless you prefix the record declaration with readonly keyword
        public readonly struct P (int A, int B);
        public static void Run() {
            // Both p1 and p2 reference the same object
            // Changing one affects the other
            ClassPoint p1 = new ClassPoint { X = 3, Y = 4 };
            ClassPoint p2 = p1;
            Console.WriteLine($"p1: X={p1.X}; p2: X={p2.X}");
            p1.X++;
            Console.WriteLine($"p1: X={p1.X}; p2: X={p2.X}");


            // Copying creates a new independent value
            StructPoint p3 = new StructPoint { X = 3, Y = 4 };
            StructPoint p4 = p3;
            Console.WriteLine($"p3: X={p3.X}; p4: X={p4.X}");
            p3.X++;
            Console.WriteLine($"p3: X={p3.X}; p4: X={p4.X}");

            RecordPoint p5 = new RecordPoint { X = 3, Y = 4 };
            RecordPoint p6 = p5;

            //Console.WriteLine(p3 == p4); Operator '==' can't be applied to opperands of type StructPoint
            Console.WriteLine(p5 == p6); // true

        }
    }

    // Class is a reference type
    // stack: reference -> heap object
    class ClassPoint { public int X; public int Y; }

    // Struct is a value type
    // Performance: They avoid heap allocation
    // Small immutable values: Things that represent a value rather than identity
    struct StructPoint { public int X; public int Y; }

    // Records were first introduced in C#9 where they acted as a compiled-enhanced class
    // Data objects are easier to write. They automatically generate:
    // Equals(), GetHashCode(), ToString(), value-based equality, 'with' cloning
    record struct RecordPoint { public int X; public int Y; }

    /*
    TYPE	EQUALITY	ALLOCATION
    
    class:	reference equality	heap
    
    record:	value equality	heap
    
    struct:	value type	stack

    Meaning that 'record struct' gives us:
        => value type
        => value equality
        => no heap allocation
        => auto-generated methods
    */
}
