using AlgorithmsCsharp.SingleLinkedList;
using AlgorithmsCsharp.WindowSlide;
using AlgorithmsCsharp.ReverseWords;
using Microsoft.VisualBasic;
using AlgorithmsCsharp.RecursionPractice;
using AlgorithmsCsharp.FindString;
using AlgorithmsCsharp.BinarySearch;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BSearch rev = new BSearch(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 }, 8);

            Console.WriteLine(rev.BSearcher());
        }
    }
}
