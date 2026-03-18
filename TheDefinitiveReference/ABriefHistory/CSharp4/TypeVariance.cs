using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp4
{
    // C#4 introduced variance for generic interfaces and delegates.
    // Type parameters can be marked as 'out' (covariant) or 'in' (contravariant),
    // allowing more natural type conversions.
    internal class TypeVariance
    {

        // Variance allows a generic type to substitute related types in a safe way. There are two kinds:
        // 1) Covariance (out) => allows using a more derived type
        // 2) Contravariance (in) => allows using a less derived type
        // C#4 added support for this in generic interfaces and delegates
        public static void Run()
        {
            // COVARIANCE
            // Lets you use a derived type where a base type is expected
            IEnumerable<string> strings = new List<string>();
            IEnumerable<object> objects = strings; // allowed because IEnumerable<T> is covariant
            // It works because => public interface IEnumerable<out T>
            // The 'out' keyowrd means the interface only outputs T, never accepts it

            // Exmaple
            IEnumerable<string> stringss = new List<string>
            {
                "one",
                "two",
                "three"
            };

            IEnumerable<object> objectss = stringss; // covariance
            foreach(var obj in objectss)
            {
                Console.WriteLine(obj);
            }

            // CONTRAVIARIANCE
            // You can use a base type where a derived type is expected
            Action<object> actObject = o => Console.WriteLine(o);
            Action<string> actString = actObject; // contravariance
            // So the method that accepts object can safely accept a string
            actString("Hello");

            // Example

            Action<object> print = oo => Console.WriteLine(oo);
            Action<string> printString = print; // contravariant assignment
            printString("Hello variance");

            // Covariance(out)
            // derived => base
            // string => object

            // Contravariance (in)
            // base => derived
            // object => string

            // OUT and IN describe how the type is used
            // out T => T is only returned (output)
            // in T => T is only consumed (input)

            // Exmaples
            // IEnumerable<out T> => produces T
            // IComparer<in T> => consumes T

            // IEnumerable<T> is covariant:
            // IEnumerable<string> => IEnumerable<object>
            // But List<T> is not:
            // List<string> =/> List<object> 
            // because lists allow adding elements which would break type safety

        }
    }
}
