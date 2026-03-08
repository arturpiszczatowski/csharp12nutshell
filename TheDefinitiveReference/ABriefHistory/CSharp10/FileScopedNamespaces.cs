using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Applies to everything that follows in the file
namespace ABriefHistory.CSharp10; // A file can contain only one file-scoped namespace

// Old block-style namespace syntax
/*
namespace A
{
    class B
    {
        class C
        {
*/

// File-scoped namespace flatten the file structure
/*
namespace A;

class B
{
    class C
    {
*/

internal class FileScopedNamespaces
{
    public static void Run()
    {
        
    }

    class Class1 { } // inside AbriefHistory.CSharp10 namespace
    class Class2 { } // inside AbriefHistory.CSharp10 namespace
}
