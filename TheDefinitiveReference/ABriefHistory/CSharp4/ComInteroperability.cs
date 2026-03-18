using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp4
{
    // COM interoperability was enhanced in C#4 in three ways
    // 1) Arguments can be passed by reference without the 'ref' keyword (particularly useful in conjunction with optional parameters)
    // 2) Assemblies that contain COM interop types can be linked rather than referenced. Linked interop types support type equivalence,
    //    avoiding the need for Primary Interop Assemblies and putting an end to versioning and deployment headaches
    // 3) Functions that return COM Variant types from linked interop types are mapped to 'dynamic' rather than 'object', eliminating the need for casting
    internal class ComInteroperability
    {
        // COM = Component Object Model
        // "Windows applications exposing programmable APIs that C# can call"
        // Examples of COM apps: Excel, Word, Outlook, Windows Shell
        public static void Run()
        {
            // Simulating COM-style dynamic usage
            dynamic obj = GetComLikeObject();

            // No compile-time checking
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Value + 10);
            // unknown shape at compile time
        }

        static dynamic GetComLikeObject()
        {
            return new { Name = "Test", Value = 5 };
        }

        // Calling Excel COM APIs used to look like this:
        /*
        excel.Workbooks.Open(
            fileName,
            Type.Missing,
            Type.Missing,
            Type.Missing,
            Type.Missing,
            Type.Missing,
            Type.Missing,
            Type.Missing
        );
        */
        // Now you can write
        // excel.Workbooks.Open(fileName);
        // Because COM methods often have many optional parameters, and C#4 supports them
        // Same for named arguments:
        // excel.Workbooks.Open(fileName, ReadOnly: true);


        // Dynamic (big improvement)
        // Before C#4
        /*
            object excel = Activator.CreateInstance(...);
            object workbooks = excel.GetType().InvokeMember(...); // reflection mess
        */
        // After C#4
        // No casting, no reflection - much cleaner
        /*
            dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
            excel.Visible = true;
            
            var workbook = excel.Workbooks.Add();
        */


        // Passing arguments without 'ref'
        // Before C#4
        /*
            object missing = Type.Missing;
            excel.Workbooks.Open(ref fileName, ref missing, ref missing);
        */
        // After C#4
        // No ref needed - the compiler handles it
        // excel.Workbooks.Open(fileName);


        // Variant => dynamic
        // COM often returns a Variant type (basically "anything")
        // Before C#4
        /*
            object value = cell.Value;
            string text = (string)value; // need cast
        */
        // After C#4
        /*
            dynamic value = cell.Value;
            string text = value; // no cast needed
        */

    }
}
