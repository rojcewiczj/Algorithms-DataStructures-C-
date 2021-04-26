
using AlgorithmsCsharp.DataStructures;
using AlgorithmsCsharp.Arrays;
using AlgorithmsCsharp.ValidString;
using AlgorithmsCsharp.FindString;
using System;
using System.Collections.Generic;

namespace AlgorithmsCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            MinNumCoinsForChange mini = new MinNumCoinsForChange(7, new int[3]{ 1, 5, 10 });

            Console.WriteLine(mini.Find());

        }
    }
}
