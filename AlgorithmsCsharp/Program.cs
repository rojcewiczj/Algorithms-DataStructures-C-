using AlgorithmsCsharp.SingleLinkedList;
using AlgorithmsCsharp.WindowSlide;
using Microsoft.VisualBasic;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowSlide.SlidingWindow slider = new WindowSlide.SlidingWindow(new int[] { 100, 200, 300, 400 }, 2);
            slider.returnLargest();

        }
    }
}
