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
            SelectionSort rev = new SelectionSort(new int[]{ 1, 5, 3, 9, 4, 32, 7, 47, 33 ,10 });

            rev.Sort();
        }
    }
}
