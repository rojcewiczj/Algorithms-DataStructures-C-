using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace AlgorithmsCsharp.Anagrams
{
    class AnagramFinder
    {
        public string _word;
        public AnagramFinder(string word)
        {
            _word = word;
        }

        public int Find()
        {
            Dictionary<string, int> dicti = new Dictionary<string, int>();
            List<string> list = new List<string>();
            List<string> substrings = new List<string>();
            int count = 0;


            for (int i = 0; i < _word.Length; i++)
            {
                for (int j = i + 1; j < _word.Length + 1; j++)
                {
                    list.Add(_word.Substring(i, j - i));
                }
            }

            foreach (var substring in list)
            {
                if (dicti.ContainsKey(substring) ||dicti.ContainsKey(Reverse(substring)))
                {
                    dicti[substring] += 1;
                    for (int k = 1; k < dicti[substring]; k++)
                    {
                        count += 1;
                    }
                }
                else
                {
                    dicti[substring] = 1;
                }

            }
            return count;

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
