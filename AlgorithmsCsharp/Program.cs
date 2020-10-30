using AlgorithmsCsharp.SingleLinkedList;
using Microsoft.VisualBasic;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.addToEnd(4);
            myList.addToEnd(7);
            myList.addToEnd(3);
            myList.addToTheBeginning(2);
            myList.Print();
        }
    }
}
