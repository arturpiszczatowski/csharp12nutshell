using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Before C#8 you could write synchronous iterators using 'yield return'
    // or asynchronous methods using 'await', but you could not combine both.
    // C#8 introduced asynchronous streams, allowing methods to both await
    // asynchronous operations and yield values one-by-one.
    internal class AsynchronousStreams
    {
        public static async Task Run()
        {
            Console.WriteLine("Synchronous stream:");
            foreach (var number in RangeSync(0, 10))
                Console.WriteLine(number);

            // 'await foreach' consumes an asynchronous stream (IAsyncEnumerable<T>).
            // Each element can be awaited before it becomes available,
            // allowing values to be processed as soon as they arrive instead of waiting for the entire sequence to complete.
            Console.WriteLine("Asynchronous stream:");
            await foreach (var number in RangeAsync(0, 10, 100)) 
                Console.WriteLine(number); 

        }

        // Async iterator method.
        // Combines 'await' (asynchronous work) with 'yield return' (streaming results).
        // Each value is produced after an asynchronous delay.
        static async IAsyncEnumerable<int> RangeAsync(int start, int count, int delay)
        {
            for(int i = start; i < start + count; i++)
            {
                await Task.Delay(delay);
                yield return i;
            }
        }

        // Traditional synchronous iterator using IEnumerable<T>.
        // Values are produced immediately without awaiting asynchronous work.
        static IEnumerable<int> RangeSync(int start, int count)
        {
            for(int i = start; i < start + count; i++)
            {
                yield return i; 
            }
        }
    }

    //Without async streams:
     //download all rows
     //return list
     //process list

    //With async streams:
     //row arrives → process
     //row arrives → process
     //row arrives → process
}
