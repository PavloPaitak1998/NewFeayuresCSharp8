using System;

namespace _001_Indices
{
    class Program
    {
        static void Main(string[] args)
        {
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

            #region Example1  
            
            // Version 1
            var lastWordV1 = words[words.Length - 1];

            // Version 2
            var lastWordV2 = words[8];

            // Version 3
            var lastWordV3 = words[^1];

            #endregion

            #region Example2

            // Using variable
            var i = 2;
            var lazyWord = words[^i];

            #endregion

            #region Example3

            // Index as variables
            Index j = ^1;
            // var j = ^1;
            var lastWord = words[j];

            #endregion

            #region Example4

            // Decompiled

            //var lastWordDecompiled = words[^1];

            var lastWordDecompiled = words[new Index(1, true).GetOffset(words.Length)];
            var firstWordDecompiled = words[new Index(1, false)];

            #endregion

            #region Example5

            // Errors

            //var indexOutOfRangeException1 = words[^0]; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            //var indexOutOfRangeException2 = words[^10]; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            #endregion

            #region CW Indices
            Console.WriteLine($"\nIndices");

            Console.WriteLine($"\nVersion 1.\n\tThe last word is {lastWordV1}");
            Console.WriteLine($"\nVersion 2.\n\tThe last word is {lastWordV2}");
            Console.WriteLine($"\nVersion 3.\n\tThe last word is {lastWordV3}");

            Console.WriteLine($"\nUsing variable\n");
            Console.WriteLine($"\nThe word is {lazyWord}");

            Console.WriteLine($"\nIndex as variables\n");
            Console.WriteLine($"\nThe word is {lastWord}");

            #endregion
        }
    }
}
