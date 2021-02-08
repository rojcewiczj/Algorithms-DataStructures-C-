using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class SelectionSort
    {
		public static int[] Sort(int[] array)
		{
			// Write your code here.
			if (array.Length == 0)
			{
				return new int[] { };
			}
			int startIdx = 0;
			while (startIdx < array.Length - 1)
			{
				int smallestIdx = startIdx;
				for (int i = startIdx + 1; i < array.Length; i++)
				{
					if (array[smallestIdx] > array[i])
					{
						smallestIdx = i;
					}
				}
				int temp = array[smallestIdx];
				array[smallestIdx] = array[i];
				array[i] = temp;
			}
			return array;
		}
	}
}
