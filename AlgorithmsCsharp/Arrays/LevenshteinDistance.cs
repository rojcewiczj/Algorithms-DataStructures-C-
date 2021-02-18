using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class LevenshteinDistance
    {
        public static string str1 = "abc";

        public static string str2 = "yabd";

        public static int Change()
        {
            // returns the amount of changes needed to make them the same (insert, delete, change)

            int[] needed_changes = new int[str2.Length];

            if(str1.Length == 0 && str2.Length > 0)
            {
                return str2.Length;
            }
            if(str1.Length ==0 && str2.Length == 0)
            {
                return 0;
            }

            int i = 0;
            int j = 0;

            while(i < str2.Length)
            {
                if(str1[i] != str2[j])
                {
                    i += 1;
                }
                else
                {
                    needed_changes[i] = 1;
                    i += 1;
                    j += 1;
                }
            }
              
            foreach(int spot in needed_changes)
            {
                Console.WriteLine(spot);
            }

            return 0;
        }
    }
}
