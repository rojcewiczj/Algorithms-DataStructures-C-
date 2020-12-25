
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
            Console.WriteLine("hello");


            MatrixAndGraph map = new MatrixAndGraph(20, 20);
            Console.WriteLine("hello");

            foreach (KeyValuePair<string, List<string>> kvp in map.connections)
            {
                Console.WriteLine("hellllooo");
                Console.Write("{0} : ", kvp.Key);
                foreach (string neighbor in kvp.Value)
                {
                    Console.Write(" {0} ", neighbor);
                }

            }

        }
    }
}
