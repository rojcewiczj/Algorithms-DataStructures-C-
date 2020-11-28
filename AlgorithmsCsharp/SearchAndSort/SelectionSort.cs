using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.SearchAndSort
{
    class SelectionSort
    {

        public int[] _arr;

        public SelectionSort(int[] arr)
        {
            _arr = arr;
        }

        public int[] Sort()
        {
            
            for(int i = 0; i < _arr.Length; i++)
            {
                int min = i ;

                for (int j = i + 1; j < _arr.Length; j++)
                {
                    if (_arr[j] < _arr[min])
                    {
                        min = j;
                    }
                }
                int mini = _arr[min];
                int old_mini = _arr[i];
                _arr[i] = mini;
                _arr[min] = old_mini;

            }

            foreach(int num in _arr)
            {
                Console.WriteLine(num);
            }

            
         
            return _arr;
        }
    }
}
