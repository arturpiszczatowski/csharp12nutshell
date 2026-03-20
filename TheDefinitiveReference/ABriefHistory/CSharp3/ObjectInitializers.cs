using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Object initializers allow setting properties or fields inline after object creation,
    // improving readability and reducing the need for multiple assignment statements.
    // They also enable the creation of anonymous types.
    internal class ObjectInitializers
    {
        public static void Run()
        {
            // Traditional way (before C#3)
            Person p1 = new Person();
            p1.Name = "Alice";
            p1.Age = 30;

            // Object initializer (C#3)
            // No constructor needed (Even if Person has a default constructor only)
            Person p2 = new Person
            {
                Name = "Bob",
                Age = 25
            };

            // Anonymous type (uses object initializer syntax)
            // This is actually an object initializer + compiler-generated type
            var anon = new
            {
                Name = "Charlie",
                Age = 15
            };

            Console.WriteLine($"{anon.Name}, {anon.Age}");

            // You can combine both
            // Constructor runs first, then properties are assigned
            var p3 = new Person("Fred")
            {
                Age = 25
            };

        }
    }

    // Object initializers can only set public properties or fields
    class Person
    {
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
