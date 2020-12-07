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

            Graph graph = new Graph();

            graph.Add("tokyo", "bejing");
            graph.Add("paris", "rome");
            graph.Add("london", "new york");
            graph.Add("london", "rome");
            graph.Add("paris", "bejing");
            graph.traversal("tokyo","new york");
            graph.print();


        }
    }
}
