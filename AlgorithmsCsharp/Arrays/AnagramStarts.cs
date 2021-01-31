using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class AnagramStarts
    {

        public static string s = "cbaebabacd";

        public static string p = "abc";


        public static List<int> Find()
        {
            List<int> output = new List<int>();
            char[] characters = p.ToCharArray();
            Array.Sort(characters);
            string sorted_p = new string(characters);
            int k = p.Length;
            string substring = "";
            for(int i = 0; i < k; i++)
            {
                substring += s[i];
                
            }
            if (IsAnagram(substring, sorted_p))
            {
                output.Add(0);
            }

            for(int i = k; i < s.Length; i++)
            {
                string current = substring.Remove(0, 1);
                current += s[i];
               
                
                if (IsAnagram(current, sorted_p))
                {
                    output.Add((i +1) - k);
                }
                substring = current;
            }
            



            return output;
        }

        public static bool IsAnagram(string substring, string sorted_p)
        {
            char[] characters = substring.ToCharArray();
            Array.Sort(characters);
            string sorted_substring = new string(characters);
            if(sorted_substring == sorted_p)
            {
                return true;
            }
            return false;
        }



    



    }
}
