using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class WordsAndKeypads
    {
        public static List<string> words = new List<string>{ "APPLE", "PLEASE", "ELEMENT", "PLE", "APE" };

        public static List<string> keypads = new List<string> { "ALPEXWY", "PLXEWAS", "KOXWYZ"};

        public static int[] Output()
        {
            int[] output = new int[keypads.Count];

            List<string> simplified_words = new List<string>();
            List<string> simplified_keypads = new List<string>();

            foreach (string word in words)
            {
                string new_word = string.Empty;
                foreach (char letter in word)
                {
                    if (!new_word.Contains(letter))
                    {
                        new_word += letter;
                    }
                    
                   
                }
                    char[] characters = new_word.ToArray();
                    Array.Sort(characters);
                    new_word = new string(characters);
                    Console.WriteLine(new_word);
                    simplified_words.Append(new_word);
            }
            foreach (string word in keypads)
            {
                string new_word = string.Empty;
                foreach (char letter in word)
                {
                    if (!new_word.Contains(letter))
                    {
                        new_word += letter;
                    }
                   
                } 
                char[] characters = new_word.ToArray();
                Array.Sort(characters);
                new_word = new string(characters);
                simplified_keypads.Append(new_word);
                Console.WriteLine(simplified_keypads.Count);
            }

            for(int i = 0; i < keypads.Count; i++)
            {
                for( int j = 0; j < words.Count; j++)
                {
                   Console.WriteLine(simplified_words[j]);
                  

                }
            }






                return output;

        }

    }
}
