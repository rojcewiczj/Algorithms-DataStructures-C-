using AlgorithmsCsharp.SingleLinkedList;
using Microsoft.VisualBasic;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagrams.AnagramFinder anag = new Anagrams.AnagramFinder("ifailuhkqq");

            Console.WriteLine(anag.Find());
        }
    }
}
