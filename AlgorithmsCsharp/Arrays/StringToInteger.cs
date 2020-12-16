using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class StringToInteger
    {
        public static string S = "   -2     ";
       
        
        public static void MakeInt()
        {    
            
            int to_return = 0;
            List<int> indexes = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '-' || Char.IsNumber(S[i]))
                {
                    indexes.Add(i);
                }
                else if (i == S.Length - 1 || indexes.Count > 0 && Char.IsWhiteSpace(S[i + 1]))
                {
                    indexes.Add(i);
                }
            }
            to_return = Int32.Parse(S.Substring(indexes[0], indexes[1]));
            Console.WriteLine(to_return);

        }
    }
}
