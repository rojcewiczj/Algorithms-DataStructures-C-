using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class FindingTripletsAlgo
    {
		public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
		{
			List<int[]> output = new List<int[]>();
			Array.Sort(array);
			int i = 0;
			while (i < array.Length - 2)
			{
				int[] inner_output = new int[3];
				int sum = 999999;
				int left = i + 1;
				int right = array.Length - 1;
				while (left < right && left <= array.Length - 1 && right > i)
				{
					sum = array[i] + array[left] + array[right];
					if (sum < targetSum)
					{
						left += 1;
					}
					else if (sum > targetSum)
					{
						right -= 1;
					}
					else
					{
						inner_output[0] = array[i];
						inner_output[1] = array[left];
						inner_output[2] = array[right];
						output.Add(inner_output);
						inner_output = new int[3];
						left += 1;
						right -= 1;
					}

				}
				i += 1;
			}

			return output;
		}
	}
}
