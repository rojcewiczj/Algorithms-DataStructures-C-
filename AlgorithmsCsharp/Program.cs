
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
           foreach(List<int> list in GroupSizes.Find())
            {
                Console.Write("[");
                foreach(int index in list)
                {
                    Console.Write(" {0} ", index);
                }
                Console.Write("]");
                Console.WriteLine("");
            }
            
        }
    }
}
