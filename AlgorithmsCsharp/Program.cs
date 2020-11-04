using AlgorithmsCsharp.SingleLinkedList;
using Microsoft.VisualBasic;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,3,3,2 };
            LargestRectangle.RectangleFinder RecFind = new LargestRectangle.RectangleFinder(array);

            Console.WriteLine(RecFind.Find());
        }
    }
}
