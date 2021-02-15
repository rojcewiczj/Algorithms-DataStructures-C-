﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class MaxSumNoAdjacent
    {
		public static int MaxSubsetSumNoAdjacent(int[] array)
		{
			if (array.Length == 0)
			{
				return 0;
			}
			else if (array.Length == 1)
			{
				return array[0];
			}
			int[] maxSums = (int[])array.Clone();
			maxSums[1] = Math.Max(array[0], array[1]);
			for (int i = 2; i < array.Length; i++)
			{
				maxSums[i] = Math.Max(maxSums[i - 1], maxSums[i - 2] + array[i]);
				Console.WriteLine(maxSums[i]);
				Console.WriteLine(maxSums[i - 2] + array[i]);
			}
			return maxSums[array.Length - 1];
		}
	}
}
