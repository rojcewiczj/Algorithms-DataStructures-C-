using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MaxSlidingWindow
    {
        public int[] nums = {1,3,-1,-3,5,3,6,7};

        public int k = 3;


        public void findMax()
        {
            List<int> maxes = new List<int>();
            int max_in_window = 0;
            int last_max = 0;
            for (int i = 0; i < k; i++)
            {
                if (nums[i] > max_in_window)
                {
                    max_in_window = nums[i];
                    last_max = i;
                }
            }
            maxes.Add(max_in_window);

            for(int i = k; i < nums.Length; i++)
            {
                if (i - last_max < 3)
                {
                    Console.WriteLine("{0} -- {1}", nums[i], nums[last_max]);
                    if (nums[i] > nums[last_max])
                    {
                        last_max = i;
                        maxes.Add(nums[i]);
                    }
                    else
                    {
                        maxes.Add(nums[last_max]);
                    }
                }
                else
                {
                    maxes.Add(nums[i]);
                    last_max = i;
                }
                
            }

            foreach(int max in maxes)
            {
                Console.WriteLine(max);
            }

        }
    }
}
