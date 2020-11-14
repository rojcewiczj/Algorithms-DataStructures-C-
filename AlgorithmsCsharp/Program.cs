using AlgorithmsCsharp.SingleLinkedList;
using AlgorithmsCsharp.WindowSlide;
using Microsoft.VisualBasic;
using AlgorithmsCsharp.ReverseWords;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            reverseWords rev = new reverseWords("hello my long lost friend!");

            Console.WriteLine(rev.reversedAllWords());
        }
    }
}
