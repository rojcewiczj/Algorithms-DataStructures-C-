
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

            LList list = new LList();
            int j = 1;
            for(int i = 1; i < 50; i++)
            {
                if (j == 10)
                {
                    j = 1;
                    list.push(j);
                    j += 1;

                }
                else
                {
                    list.push(j);
                    j += 1;
                    
                }
            }
            list.patternMarker();
            list.print();


        }
    }
}
