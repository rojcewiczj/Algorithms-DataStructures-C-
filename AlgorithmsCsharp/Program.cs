using AlgorithmsCsharp.SingleLinkedList;
using AlgorithmsCsharp.WindowSlide;
using AlgorithmsCsharp.ReverseWords;
using Microsoft.VisualBasic;
using AlgorithmsCsharp.RecursionPractice;
using AlgorithmsCsharp.FindString;
using AlgorithmsCsharp.SearchAndSort;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSort rev = new InsertionSort(new int[]{ 3, 4, 8, 2, 11, 7, 1 });

            rev.Sort();
        }
    }
}
