using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class PaliPairs
    {
        public static string[] words = { "abcd", "dcba", "lls", "s", "sssll" };



        
        public static bool Palidrome(string first, string second)
        {
            string combined = string.Empty;
            string word = first;
            int i = 0;

            while( i < 2) {

                for(int j = 0; j < word.Length; j ++)
                    {
                        combined += word[j];
                    }
                
                word = second;
                i += 1;
             }

            string reversed = string.Empty;

            for(int k = combined.Length-1; k > -1; k--)
            {
                reversed += combined[k];
            }

            if(reversed == combined)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        public static List<List<int>> Find()
        {
            List<List<int>> output = new List<List<int>>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (j != i)
                    {
                        if (Palidrome(words[i], words[j]))
                        {
                            List<int> pair = new List<int> { i, j };
                            output.Add(pair);
                        }
                    }

                }
            }

            return output;
        }
    }
}
