using AlgorithmsCsharp.SingleLinkedList;
using Microsoft.VisualBasic;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoStrings.TwoStringsFinder Finder = new TwoStrings.TwoStringsFinder("hi", "world");

            Console.WriteLine(Finder.Find());
        }
    }
}
