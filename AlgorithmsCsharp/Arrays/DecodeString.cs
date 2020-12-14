using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class DecodeString
    {
        public static string S = "leet2code3";

        public static int K = 10;


      

        public static char findK()
        {
            char kth = 'k';
            string current_string = "";

            for (int i = 0; i < S.Length; i++)
            {
                if (Char.IsDigit(S[i]))
                {
                    string addToString = "";
                    for (int j = 0; j < (int)(S[i] - '0'); j++)
                    {

                        addToString += current_string;
                        
                 
                        
                    }
                    current_string = addToString;
                }
                else
                {
                    current_string += S[i];
                }
            }

            Console.WriteLine(current_string);

            return kth;


        }
    }
}
