using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class ValidSubsequence
    {
        public static int[] array = { 5, 1, 22, 25, 6, -1, 8, 10,24,11 };

        public static int[] seq = { 1, 6, -1, 10 };




        public static bool Valid()
        {
            int last = 0;
            int check = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = last; j < array.Length; j++)
                {
                    if (seq[i] == array[j])
                    {
                        last = j + 1;
                        check += 1;
                        break;
                    }
     
                }
                if(check == seq.Length)
                {
                    return true;
                }
            
            }

            return false;

        }
    }


    
}
