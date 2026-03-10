using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // If you omit the brackets and statements block following a using statement, it becomes a 'using declaration'
    // The resource is then disposed when execution falls outside the enclosing statement block
    internal class UsingDeclarations
    {
        public static void Run()
        {
            // In this case, reader will be disposed when exectuion falls outside the if statement block
            if(File.Exists("file.txt"))
            {
                using var reader = File.OpenText("file.txt");
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
