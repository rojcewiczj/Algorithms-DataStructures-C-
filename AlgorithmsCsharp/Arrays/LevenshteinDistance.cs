using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class LevenshteinDistance
    {
        public static string str1 = "biting";

        public static string str2 = "mitten";

        public static int Change()
        {
            // returns the amount of changes needed to make them the same (insert, delete, change)

            int[] needed_changes = new int[str2.Length];
            int count = 0;
            if(str1.Length == 0 && str2.Length > 0)
            {
                return str2.Length;
            }
            if(str1.Length ==0 && str2.Length == 0)
            {
                return count;
            }
            count = str2.Length;
            Dictionary<char, int> dicti = new Dictionary<char, int>();
            
            foreach(char letter in str2)
            {
                if (!dicti.ContainsKey(letter))
                {
                    dicti[letter] = 1;

                }
                else
                {
                    dicti[letter] += 1;
                }
                  
            }

            foreach(char letter in str1)
            {
                if (dicti.ContainsKey(letter))
                {
                    dicti[letter] -= 1;
                    if(dicti[letter] <= 0)
                    {
                        dicti.Remove(letter);
                    }
                    count -= 1;
                }
                
            }

            Console.WriteLine(count);
            return count;
            
        }
    }
}
