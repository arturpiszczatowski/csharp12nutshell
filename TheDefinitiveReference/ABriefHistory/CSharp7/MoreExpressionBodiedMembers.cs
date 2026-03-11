using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    // C#6 introduced the expression-bodied "fat-arrow" syntax for methods, read-only properties, operators, and indexers
    // C#7 extends this to constructors, read/write properties and finalizers
    internal class MoreExpressionBodiedMembers
    {
        public static void Run()
        {
            CreatePerson();

            Console.WriteLine("Forcing GC...");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

        }

        // We use seperate method to make the object go out of scope sooner
        public static void CreatePerson()
        {
            Person p = new Person("Alice");
        }
    }

    public class Person
    {
        string name;


        // Expression-bodied constructor
        public Person(string name) => Name = name;

        public string Name
        {
            get => name;
            set => name = value ?? "";
        }

        // Finalizer is rarely used and runs when the garbage collector destroys the object
        // They are meant to clean up unmanaged resources, like:
        // file handles, OS resources, native memory
        // They slow down garbage collection
        // The run unpredictably
        // Normally in C# IDisposable is preferred instead
        ~Person() => Console.WriteLine("finalize");
    }
}
