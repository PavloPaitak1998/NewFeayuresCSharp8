using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _002_Ranges
{
    class Program
    {
        static void Main(string[] args)
        {
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

            #region Example1

            // Version 1
            var quickBrownFoxV1 = new string[3];

            Array.Copy(words, 1, quickBrownFoxV1, 0, 3);

            // Version 2
            var quickBrownFoxV2 = words.Skip(1).Take(3).ToArray();

            // Version 3
            var quickBrownFoxV3 = words[1..4];

            #endregion

            #region Example2

            // Posibilities
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

            #endregion

            #region Example3

            // Using Variable
            var i = 1;
            var The = words[..i];

            #endregion

            #region Example4

            // Ranges as variables
            Range phrase = 1..4;
            //var phrase = 1..4;

            var text = words[phrase];

            #endregion

            #region Example5

            // Decompiled
            // var quickBrownFoxV3 = words[1..4];
            var textDecompiled = RuntimeHelpers.GetSubArray(words, new Range(1, 4));

            #endregion

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
        }
    }
}
