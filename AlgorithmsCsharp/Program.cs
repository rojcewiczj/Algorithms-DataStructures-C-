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
            BSTTree tree = new BSTTree();

            tree.insert(1);
            tree.insert(2);
            tree.insert(4);
            tree.insert(10);
            tree.insert(3);
            tree.insert(14);
            tree.insert(5);
            tree.insert(6);
            tree.print_tree();

        }
    }
}
