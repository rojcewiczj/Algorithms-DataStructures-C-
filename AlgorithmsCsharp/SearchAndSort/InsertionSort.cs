using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.SearchAndSort
{
    class InsertionSort
    {
        public int[] arr;


        public InsertionSort(int[] _arr)
        {
            arr = _arr;
        }

        public int[] Sort()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int to_switch = i;
                int current = arr[i];
                

                for (int j = i - 1; j > -1 && arr[j] > current; j--)
                {
                    arr[j + 1] = arr[j];
                    to_switch = j;
                }

                arr[to_switch] = current;

            }

        
            foreach(int num in arr)
            {
                
               Console.Write(" {0} ", num);
            }
        
           
            return arr;
        }

    }
}
