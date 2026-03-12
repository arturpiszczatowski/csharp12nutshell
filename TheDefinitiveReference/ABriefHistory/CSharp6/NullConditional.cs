using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp6
{
    // The null-conditional ("Elvis") operator avoid having to explicitly check for null before calling a method or accessing a tpye member
    internal class NullConditional
    {
        public static void Run()
        {
            // Result evaluates to null instead of throwing a NullReferenceException
            System.Text.StringBuilder sb = null;
            string result = sb?.ToString();
        }
    }
}
