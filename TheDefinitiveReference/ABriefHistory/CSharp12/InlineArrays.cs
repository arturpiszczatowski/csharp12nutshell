using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp12
{
    // Allows creation of a fixed-size inline buffer in a struct without unsafe fixed buffers.
    // This feature is mainly intended for high-performance and runtime-related scenarios.
    // To sum up: InlineArray lets a struct contain fixed-size array storage directly inside itself, and Span<T> provides safe array-like access to that storage.
    internal class InlineArrays
    {
        public static void Run()
        {
            Buffer buffer = new Buffer();

            for (int i = 0; i < 5; i++) buffer[i] = i * 10;

            // This means: Treat the moemory inside buffer as a span of 5 integers
            // This is roughly:
            // span.pointer => adress of buffer._element0
            // span.length => 5
            // Span gives array-like access to the inline data without allocating a separate array.
            Span<int> span = buffer;

            foreach(var value in span) Console.WriteLine(value);

            // buffer stores 5 ints inline, in contiguous memory.
            // Since buffer is a local variable here, it will typically live on the stack.
            // The span acts as a window over that inline storage.
        }
    }

    // This tells the compiler: Create a struct that behaves like an array with 5 elements of the field's type
    // Field type is int so this becomes conceptually int[5]
    // Since int = 4 bytes => 5 * 4 bytes = 20 bytes
    [InlineArray(5)]
    public struct Buffer
    {
        private int _element0;
    }

    // Old way
    unsafe struct Buffer_un
    {
        public fixed int values[5];
    }
}
