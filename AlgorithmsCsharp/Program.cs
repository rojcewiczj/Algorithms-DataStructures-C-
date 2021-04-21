
using AlgorithmsCsharp.DataStructures;
using AlgorithmsCsharp.Arrays;
using AlgorithmsCsharp.ValidString;
using AlgorithmsCsharp.FindString;
using System;
using System.Collections.Generic;

namespace AlgorithmsCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            MergeSort.printArray(arr);
            MergeSort.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            MergeSort.printArray(arr);
            
            //stack
            // sort(sort left, sort right, merge)
        }
    }
}
