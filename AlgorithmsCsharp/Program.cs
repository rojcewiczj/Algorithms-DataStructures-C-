using AlgorithmsCsharp.SingleLinkedList;
using AlgorithmsCsharp.WindowSlide;
using AlgorithmsCsharp.ReverseWords;
using Microsoft.VisualBasic;
using AlgorithmsCsharp.RecursionPractice;
using AlgorithmsCsharp.FindString;
using AlgorithmsCsharp.SearchAndSort;
using AlgorithmsCsharp.DataStructures;
using System;
using System.Collections.Generic;

namespace AlgorithmsCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            MaxBinaryHeap heap = new MaxBinaryHeap();

            heap.insert(1);
            heap.insert(2);
            heap.insert(4);
            heap.insert(10);
            heap.insert(3);
            heap.insert(14);
            heap.insert(5);
            heap.insert(6);
            heap.print();

        }
    }
}
