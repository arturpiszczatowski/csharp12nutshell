using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // Indices and ranges simplify working with elements or portions of an array (or the low-level types Span<T> and ReadOnlySpan<T>)
    internal class IndicesAndRanges
    {
        public static void Run()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            // Indices let yoyu refer to elements relative to the end of an array by using the ^ operator
            char lastElement = vowels[^1];
            char secondToLast = vowels[^2];

            // ranges let you "slice" an array by using the .. operator
            char[] firstTwo = vowels[..2]; // a e
            char[] lastThree = vowels[2..]; // i o u
            char[] middleOne = vowels[2..3]; // i
            char[] lastTwo = vowels[^2..]; // o u

        }

        // You can support indices and ranges in your won classes by defining and indexer with a parameter type of Index or Range
        class Sentence
        {
            string[] words = "The quick brown fox".Split();

            public string this[Index index] => words[index];
            public string[] this[Range range] => words[range];
        }

    }
}
