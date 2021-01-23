
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
           foreach(List<int> pair in PaliPairs.Find())
            {
                Console.Write(" [{0},{1}] ", pair[0], pair[1]);
            }

            
        }
    }
}
