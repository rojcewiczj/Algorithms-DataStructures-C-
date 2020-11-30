using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.SearchAndSort
{
    class MergeSort
    {
        public List<int> arr;

        public MergeSort(List<int> _arr)
        {
            arr = _arr;
        }


        public List<int> Merge(List<int> arr_left, List<int> arr_right)
        {
            int i = 0;
            int j = 0;

            List<int> merged_arr = new List<int>();

            while (i < arr_left.Count && j < arr_right.Count)
            {
                if (arr_left[i] < arr_right[j])
                {
                    merged_arr.Add(arr_left[i]);
                    i += 1;

                }
                else if (arr_right[j] < arr_left[i])
                {
                    merged_arr.Add(arr_right[j]);
                    j += 1;
                }

            }
            while (i < arr_left.Count)
            {
                merged_arr.Add(arr_left[i]);
                i++;
            }

            while (j < arr_right.Count)
            {
                merged_arr.Add(arr_right[j]);
                j++;
            }



            return merged_arr;
        }

        public List<int> Split(List<int> _arr)
        {
            if (_arr.Count <= 1)
            {
                return _arr;
            }
            
            
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = _arr.Count / 2;

            for (int i = 0; i < mid; i++)
            {
                left.Add(_arr[i]);
            }
            for (int i = mid; i < _arr.Count; i++)
            {
                right.Add(_arr[i]);
            }
            left = Split(left);
            right = Split(right);
            return Merge(left, right);
        }

    }
}
