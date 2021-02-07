using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class BinarySearch
    {
        


		public static int BinaryS(int[] array, int target)
		{
			// Write your code here.
			int low = 0;
			int high = array.Length - 1;
			while (low <= high)
			{
				int mid = (low + high) / 2;
				if (array[mid] == target)
				{
					return mid;
				}
				if (target > array[mid])
				{
					low = mid + 1;
				}
				else if (target < array[mid])
				{
					high = mid - 1;
				}
			}
			return -1;
		}


	}


}
