using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp5
{
    // Asynchronous functions enable asynchronous continuations
    // They make it easier to write responsive and thread-safe rich-client applications
    // They make it easy to write highly concurrent and efficient I/O-bound applications that don't tie up a thread resource per operation
    internal class AsynchronousFunctions
    {
        public static async Task Run()
        {
            Console.WriteLine("Starting work...");

            int result = await SlowOperation();

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Finished");

            await RunOldStyle();
        }

        static async Task<int> SlowOperation()
        {
            Console.WriteLine("Working...");

            await Task.Delay(2000); // Simulates asnychronous I/O

            return 420;
        }

        // Before C#5 async/await, asynchronous code often used Task continuations
        static Task RunOldStyle() {
            Console.WriteLine("Starting work...");

            return Task.Delay(2000).ContinueWith(t =>
            {
                Console.WriteLine("Working...");

                return Task.Delay(2000).ContinueWith(t2 =>
                {
                    int result = 420;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Finished");
                });
            }).Unwrap();
            // Unwrap() is needed because 'ContinueWith(...) returns a Task<Task>
            // When the continuation itself returns a Task Unwrap() flattens it into a single Task
        }
    }
}
