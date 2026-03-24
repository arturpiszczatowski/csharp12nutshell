using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp2
{
    // Fixed-size buffers allow inline arrays inside structs using unsafe code.
    // Used mainly for:
    // 1) interop with native code (C/C++)
    // 2) high-performance scenarios
    // 2) memory layout control
    // and require the 'unsafe' keyword and fixed size at compile time.
    internal class FixedSizeBuffers
    {
        // You must enable
        // <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
        public static void Run()
        {
            unsafe
            {
                Buffer buffer = new Buffer();

                for (int i = 0; i < 5; i++)
                    buffer.values[i] = i * 10;

                for (int i = 0; i < 5; i++)
                    Console.WriteLine(buffer.values[i]);

            }
            
            // Normal array
            int[] arr = new int[5];
            // Stored on heap
            // Reference type
            // Flexible size
        }

        unsafe struct Buffer
        {
            // This means: store 5 integers directly inside the struct
            public fixed int values[5]; //fixed-size buffer
            // Stored inline in struct
            // No allocation
            // Fixed size
            // Unsafe
            

            // Memory layout:
            // | int | int | int | int | int |
            // No heap allocation
            // No seperate array object
        }
    }
}
