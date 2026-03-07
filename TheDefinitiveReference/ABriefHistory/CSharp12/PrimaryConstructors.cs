using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.C_12
{
    internal class PrimaryConstructors
    {
        public static void Run()
        {
            // This instructs the compiler to automatically build a primary constructor, allowing parameters to be used inside the class body
            Person p = new Person("Alice", "Jones");
            p.Print();

            // These don't exist
            Console.WriteLine("Can't call p.FirstName");
            Console.WriteLine("Can't call p.LastName");

            Person_explicit p_e = new Person_explicit("Brodo", "Faggins");
            // These exist
            Console.WriteLine(p_e.FirstName);
            Console.WriteLine(p_e.LastName);
        }
        class Person(string firstName, string lastName)
        {
            // You can include a parameter list directly after a class (or struct) declaration
            public void Print() => Console.WriteLine(firstName + " " + lastName);
        }

        class Person_explicit(string firstName, string lastName)
        {
            public string FirstName { get; set; } = firstName;
            public string LastName { get; set; } = lastName;
        }
    }
}
