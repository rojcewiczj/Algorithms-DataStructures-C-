using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class OverlapingSub
    {
        public static int[] nums = new int[] { 1, 2, 2, 3, 2, 6, 7, 2, 1, 4, 8 };

        public static int target = 5;


        public static int Find()
        {
            int shortest_sub = 0;
            List<List<int>> sub_arrays = new List<List<int>>();
            List<int> lengths = new List<int>();
            int k = nums.Length;
          
                List<int> sub_arr = new List<int>();
                int total = 0;
            for (int i = 0; i < k; i++)
            {

                sub_arr.Add(nums[i]);
                total += nums[i];
              

                if (total == target)
                {
                    sub_arrays.Add(sub_arr);
                    sub_arr = new List<int>();
                    i -= 1;
                    total = 0;
                }
                else if (total > target)
                {
                    total -= sub_arr[0];
                    sub_arr.RemoveAt(0);
                }


            }

            if (total == target)
            {
                sub_arrays.Add(sub_arr);
                sub_arr = new List<int>();
                total = 0;
            }
            else if (total > target)
            {
                total -= sub_arr[0];
                sub_arr.RemoveAt(0);
            }


            foreach (List<int> sub in sub_arrays)
            { 
                foreach(int num in sub)
                {
                    Console.Write(" {0} ", num);
                }

                Console.WriteLine(" ");

            }


            return -1;


        }
    }
}
