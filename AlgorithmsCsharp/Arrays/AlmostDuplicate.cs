using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class AlmostDuplicate
    {
        public int[] nums = new int[] { 1, 5, 9, 1, 5, 9, 7, 12, 3 };

        public int k = 3;

        public int t = 3;

        public int find_min(List<int> current_window, int max_diff)
        {
            int diff = max_diff;
            for (int i = 0; i < current_window.Count - 2; i++)
            {
                if (current_window[i + 1] - current_window[i] < max_diff)
                {
                    diff = current_window[i + 1] - current_window[i];

                }
            }
            return diff;
        }

        public void check()
        {
            bool works = false;
            List<int> current_window = new List<int>();
            List<int> differences = new List<int>();
            int last = k;
            int max_diff = t + 1;

            for (int i = 0; i < k; i++)
            {

                current_window.Add(nums[i]);
            }

            current_window.Sort();

            int current_diff = find_min(current_window, max_diff);

          
            differences.Add(current_diff);
            
            current_window = new List<int>();

            while (last < nums.Length - 1)
            {

                for (int i = last; i < last + k || i < nums.Length; i++)
                {
                    current_window.Add(nums[i]);
                }
                current_window.Sort();

                current_diff = find_min(current_window, max_diff);

                
                
                differences.Add(current_diff);
                
                current_window = new List<int>();
                last = last + k;
            }


            foreach(int diff in differences)
            {
                Console.WriteLine(diff);
            }
        }
    }

}
 