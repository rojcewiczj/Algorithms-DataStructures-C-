using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.FindString
{
    class banagram
    {
       public static string word1 = "aba";

       public static string word2 = "bab";

        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            string new_string = new string(characters);
            return new_string;
        }

    
        public static void canAn()
        {
            string word1_sorted = SortString(word1);

            string word2_sorted = SortString(word2);

           
            int count = 0;
            for(int i = 0; i < word1.Length; i++)
            {  
               
               if(word1_sorted[i] != word2_sorted[i])
                {
                    count += 1;


                }
            }

            Console.WriteLine(count);

           
        }







            
        

    }
}
