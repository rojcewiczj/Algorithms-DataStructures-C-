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
   
            PriorityQueue PQ = new PriorityQueue();


            PQ.Insert(new PQNode("common cold", 5));
            PQ.Insert(new PQNode("fever", 3));
            PQ.Insert(new PQNode("heart attack", 1));
            PQ.Insert(new PQNode("broken arm", 2));
            PQ.Insert(new PQNode("chopped arm", 6));
            PQ.Insert(new PQNode("itchy arm", 8));
           

            PQ.print();

        }
    }
}
