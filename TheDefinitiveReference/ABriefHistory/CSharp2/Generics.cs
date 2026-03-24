using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp2
{
    // Generics allow defining classes, methods, and collections with type parameters,
    // enabling type-safe reuse without casting or boxing.
    internal class Generics
    {
        // Generics = write code once, use it with any type safely
        public static void Run()
        {
            // Before generics, collections stored object
            // Problems:
            // 1) no type safety
            // 2) runtime errors
            // 3) boxing/unboxing (performance)
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("hello");

            int x = (int)list[0]; // casting required
            

            // 1. Type-safe collection
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            // numbers.Add("hello"); compile-time error

            int y = numbers[0]; // no cast needed

            // 2. Generic method
            Console.WriteLine(Identity(3));
            Console.WriteLine(Identity("hello"));

            // 3. Generic class
            var box = new Box<string>("hello");
            Console.WriteLine(box.Value);
            

        }

        // 2. Generic method
        public static T Identity<T>(T value)
        {
            return value;
        }

        // 3. Generic class
        class Box<T>
        {
            public T Value { get; set; }
            public Box(T value)
            {
                Value = value;
            }
        }
    }

}
