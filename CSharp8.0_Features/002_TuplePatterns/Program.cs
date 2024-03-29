﻿using System;

namespace _002_TuplePatterns
{
    class TuplePatterns
    {
        public static string RockPaperScissors(string first, string second) =>
            (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                ("scissors", _) => "scissors wtf ?",
                (_, "paper") => "paper wtf ?",
                (_, _) => "tie"
                //, _ => "tie"
            };
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
