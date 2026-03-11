using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp7
{
    // Whereas a consctructor typically takes a set of values (as parameters) and assigns them to fields
    // a deconstructor does the reverse and assigns fields back to a set of variables
    internal class Deconstructors
    {
        public static void Run()
        {
            // Deconstructors are called with the following special syntax
            var joe = new Person("Joe Bloggs");
            var (first, last) = joe; // Deconstruction (the number of variables must match the number of parameters)
            Console.WriteLine(first);
            Console.WriteLine(last);
        }

        public class Person
        {
            string name { get; set; }

            // Constructor => values => object
            // Deconstructor => object => values 
            public Person(string name) => Name = name;

            public string Name
            {
                get => name;
                set => name = value ?? "";
            }

            // The object must have a Deconstruct method
            // The method has to use 'out' parameters
            // Class can have multiple Deconstructors
            public void Deconstruct(out string firstName, out string lastName)
            {
                int spacePos = name.IndexOf(' ');
                firstName = name.Substring(0, spacePos);
                lastName = name.Substring(spacePos + 1);
            }
        }
    }
}
