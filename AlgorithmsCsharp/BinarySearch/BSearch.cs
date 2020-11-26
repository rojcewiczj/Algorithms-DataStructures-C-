using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.BinarySearch
{
    class BSearch
    {

        public int[] _arr;

        public int _num;

        public BSearch(int[] arr, int num)
        {
            _arr = arr;
            _num = num;
        }


       
        public int BSearcher()
        {
            int start = 0;
            int end = _arr.Length - 1;
            int mid = (start + end) / 2;
            while (_arr[mid] != _num)
            {
                
                if (_num > _arr[mid])
                {
                    start = mid + 1;
                }
                else if (_num < _arr[mid])
                {
                    end = mid - 1;
                }
                mid = (start + end) / 2;
                Console.WriteLine(mid);
            }
            







            return mid;

        }
    }
}
