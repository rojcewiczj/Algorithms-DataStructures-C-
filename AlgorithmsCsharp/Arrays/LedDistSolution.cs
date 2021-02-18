using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class LedDistSolution
    {
        public static int LevenshteinDistance(string str1, string str2)
        {
            int[,] edits = new int[str2.Length + 1, str1.Length + 1];
            for(int i = 0; i < str2.Length +1; i++)
            {
                for(int j = 0; j <str1.Length +1; j++)
                {
                    edits[i, j] = j;
                }
            }

        }
    }
}
