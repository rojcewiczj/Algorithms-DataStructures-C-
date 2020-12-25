using AlgorithmsCsharp.SingleLinkedList;
using AlgorithmsCsharp.WindowSlide;
using AlgorithmsCsharp.ReverseWords;
using Microsoft.VisualBasic;
using AlgorithmsCsharp.RecursionPractice;
using AlgorithmsCsharp.FindString;
using AlgorithmsCsharp.SearchAndSort;
using AlgorithmsCsharp.DataStructures;
using AlgorithmsCsharp.Arrays;
using AlgorithmsCsharp.ValidString;
using System;
using System.Collections.Generic;

namespace AlgorithmsCsharp
{
    class Program
    {

        static void Main(string[] args)
        {

            MatrixAndGraph map = new MatrixAndGraph(20, 20);

            foreach(KeyValuePair<string, List<string>> kvp in map.connections)
            {
                Console.WriteLine(" ");
                Console.Write("{0} : ", kvp.Key);
                foreach (string neighbor in kvp.Value)
                {
                    Console.Write(" {0} ", neighbor);
                }

            }

        }
    }
}
