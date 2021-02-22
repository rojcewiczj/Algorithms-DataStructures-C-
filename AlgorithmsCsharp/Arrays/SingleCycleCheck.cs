using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class SingleCycleCheck
    {
        int[] array = new int[] { 2, 3, 1, -4, -4, 2 };

        public static bool HasSingleCycle(int[] array)
        {
            int num_elements_visited = 0;
            int current_index = 0;
            while(num_elements_visited < array.Length)
            {
                if(num_elements_visited > 0 && current_index == 0)
                {
                    return false;
                }
                num_elements_visited += 1;
                current_index = getNextIdx(current_index, array);
            }
            return current_index == 0;

        }

        public static int getNextIdx(int index, int[] array)
        {
            int jump = array[index];
            int next_index = (index + jump) % array.Length;
            if(next_index >= 0)
            {
                return next_index;
            }
            else
            {
                return next_index + array.Length;
            }
        }
    }
}
