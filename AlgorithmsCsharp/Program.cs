
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
           


            MatrixAndGraph map = new MatrixAndGraph(20, 20);


          
            foreach(string local in map.Trip("1,2","10,11"))
            {
                Console.Write("- {0} -", local);
            }


        }
    }
}
