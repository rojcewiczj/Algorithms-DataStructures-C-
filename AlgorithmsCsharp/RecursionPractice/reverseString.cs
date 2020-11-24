using System;

namespace AlgorithmsCsharp.RecursionPractice { 
public class reverseString
{
    public readonly string _string;

    public string reversed_string;

        public reverseString(string toReverse)
        {
            _string = toReverse;


        }

    
   
    public string rec_func(string newString, int i)
        {
            if (i > -1)
            {
                newString += _string[i];
            }
            else if ( i <= -1){
                return newString;
            }
            return rec_func(newString, i - 1);
            
            
        }

    public string reverseThis()
    {
            string newString = string.Empty;

            int i = _string.Length -1;

            reversed_string = rec_func(newString, i);

            return reversed_string;

    }
}
}
