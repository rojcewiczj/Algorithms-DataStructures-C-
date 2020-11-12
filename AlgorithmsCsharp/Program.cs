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
            ValidString.ValidString validator = new ValidString.ValidString("abcdefghhgfedecba");
            Console.WriteLine(validator.returnValid());

        }
    }
}
