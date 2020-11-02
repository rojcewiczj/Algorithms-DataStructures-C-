using AlgorithmsCsharp.SingleLinkedList;
using Microsoft.VisualBasic;
using System;

namespace AlgorithmsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hourglass.HourGlassAdder hourglass = new Hourglass.HourGlassAdder();
            Console.WriteLine(hourglass.FindMax());
            
        }
    }
}
