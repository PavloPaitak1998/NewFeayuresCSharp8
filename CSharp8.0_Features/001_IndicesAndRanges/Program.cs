using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _001_IndicesAndRanges
{
    // Indices and Ranges

    // The index from end operator - [^]
    // The range operator - [..]

    class Program
    {
        static void Main(string[] args)
        {
            #region Indices
             /*
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            // Version 1
            var lastWordV1 = words[words.Length - 1];

            // Version 2
            var lastWordV2 = words[8];

            // Version 3
            var lastWordV3 = words[^1];

            // Uing variable
            var i = 2;
            var lazyWord = words[^i];

            // Index as variables
            Index j = ^1;
            // var j = ^1;
            var lastWord = words[j];

            var lastWordDecompiled = words[new Index(1, true).GetOffset(words.Length)];
            var firstWordDecompiled = words[new Index(1, false)];

            #region CW Indices
            Console.WriteLine($"\nIndices");

            Console.WriteLine($"\nVersion 1.\n\tThe last word is {lastWordV1}");
            Console.WriteLine($"\nVersion 2.\n\tThe last word is {lastWordV2}");
            Console.WriteLine($"\nVersion 3.\n\tThe last word is {lastWordV3}");
            Console.WriteLine($"\nThe {i} word is {lazyWord}");
            #endregion

            //var indexOutOfRangeException1 = words[^0]; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            //var indexOutOfRangeException2 = words[^10]; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
             */
            #endregion

            #region Ranges
            // /*
            var words = new string[]
            {
                "The",      // 0
                "quick",    // 1
                "brown",    // 2
                "fox",      // 3
                "jumped",   // 4
                "over",     // 5
                "the",      // 6
                "lazy",     // 7
                "dog"       // 8
            };              // 9


            // Version 1
            var quickBrownFoxV1 = new string[3];

            Array.Copy(words, 1, quickBrownFoxV1, 0, 3);

            // Version 2
            var quickBrownFoxV2 = words.Skip(1).Take(3).ToArray();

            // Version 3
            var quickBrownFoxV3 = words[1..4];

            // Posibilities
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

            // Ranges as variables
            Range phrase = 1..4;
            //var phrase = 1..4;

            var text = words[phrase];

            var textDecompiled = RuntimeHelpers.GetSubArray(words, new Range(1, 4));

            #region CW Ranges
            Console.WriteLine($"\nRanges");

            Console.WriteLine($"\n\tVersion 1\n");

            foreach (var item in quickBrownFoxV1)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine($"\n\tVersion 2\n");

            foreach (var item in quickBrownFoxV2)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine($"\n\tVersion 3\n");

            foreach (var item in quickBrownFoxV3)
            {
                Console.WriteLine($"\t{item}");
            }
            #endregion
            // */
            #endregion
            
            // .NET types support both indices and ranges: Array, String, Span<T>, and ReadOnlySpan<T>.
            // The List<T> supports indices but doesn't support ranges.
        }
    }
}
