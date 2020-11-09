using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MinSwap
    {
        private int[] _nums;

        public MinSwap(int[] nums)
        {
            _nums = nums;
        }

        public int FindMinSwap()
        {
            int minSwap = 0;
            int i = 0;

            while (i < _nums.Length)
            {
                while (_nums[i] != i + 1)
                {
                    int toSwitch = _nums[_nums[i] - 1];
                    int currentNum = _nums[i];
                    _nums[i] = toSwitch;
                    _nums[_nums[i] - 1] = currentNum;
                    minSwap += 1;
                    Console.WriteLine("{0} -- {1} // ", toSwitch, currentNum);
                }
                i += 1;
            }
            return minSwap;
        }


    }
}
