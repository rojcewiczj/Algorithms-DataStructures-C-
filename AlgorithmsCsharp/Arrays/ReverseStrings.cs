using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
     public static class ReverseStrings
    {

        public static string Reverse(string words)
        {
           string final_word = "";

           string[] array = words.Split();
           List<string> new_array = new List<string>();
           foreach(string word in array)
            {
                string new_word = "";

                for(int i = word.Length -1; i > -1; i--)
                {
                    new_word += word[i];
                }
                Console.WriteLine(new_word);
                new_array.Add(new_word);
            }

            final_word = String.Join(" ", new_array);
            Console.WriteLine(final_word);

            return final_word;

        }
    }
}
