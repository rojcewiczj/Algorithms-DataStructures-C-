using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.ReverseWords
{
    class reverseWords
    {
        private string words;

        public reverseWords(string _string)
        {
            words = _string;
        }


        public string reversedAllWords()
        {

            string newString = string.Empty;

            string newWord = string.Empty;

            string last = string.Empty;

            for(int i = words.Length -1; i > -1; i--)
            {

                if (!Char.IsLetterOrDigit(words[i]))
                {
                    last += words[i];
                }
                if(!Char.IsWhiteSpace(words[i]) && Char.IsLetterOrDigit(words[i]))
                { 
                newWord += words[i];
                }

                if (Char.IsWhiteSpace(words[i]) || i == 0)
                {

                    for (int j = newWord.Length - 1; j > -1; j--)
                    {
                        newString += newWord[j];
                    }
                    if(i != 0) { 
                    newString += " ";
                     newWord = string.Empty;
                    }
                    else
                    {
                        newString += last;
                    }
                }
               
                
                
                
            }

            



            return newString;

        }
    }
}
