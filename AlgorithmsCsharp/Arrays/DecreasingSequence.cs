using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class DecreasingSequence
    {
        public static List<int> nums = new List<int>{2, 7, 11, 15};

        public static int target = 9;
        public static List<int> CanFix()
        {
            List<int> to_return = new List<int>();
            bool nothing_found = true;
            int to_find = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nothing_found == true)
                {

                    if (nums.Contains(target - nums[i]))
                    {
                        to_return.Add(i);
                        to_find = target - nums[i];
                        nothing_found = false;
                    }
                }
                else
                {
                    if (nums[i] == to_find)
                    {
                        to_return.Add(i);
                    }
                }
            }

            return to_return;

        }
    }
}
