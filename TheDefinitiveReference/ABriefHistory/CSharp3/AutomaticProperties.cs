using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp3
{
    // Automatic properties let the compiler generate the backing field,
    // reducing boilerplate for simple get/set properties.
    internal class AutomaticProperties
    {
        public static void Run()
        {
            var human = new Human
            {
                Name = "Alice",
                Age = 30
            };

            Console.WriteLine($"{human.Name}, {human.Age}");
        }
    }

    // Before C#3 you had to write
    class HumalOld
    {
        private string name;
        private int age;

        // Don't use automatic properties when you need logic:
        public string Name
        {
            get { return name; }
            // Extra logic
            set { name = value ?? "Unknow"; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    class Human
    {
        // Automatic properties
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
