using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class HashTable
    {


        public static int Hash(string _string)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(_string);
            int num_val = 0;

            foreach (byte ascii in asciiBytes)
            {
                num_val += ascii;
            }
            return num_val;
        }
    }
}
