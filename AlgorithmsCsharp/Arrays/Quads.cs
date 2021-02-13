using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class Quads
    {
		public static List<int[]> FourNumberSum(int[] array, int targetSum)
		{
			Dictionary<int, List<List<int>>> dicti = new Dictionary<int, List<List<int>>>();
			List<int[]> quads = new List<int[]>();
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; i < array.Length; i++)
				{
					if (j != i)
					{
						int currentSum = array[i] + array[j];
						int currentDiff = targetSum - currentSum;
						if (!dicti.ContainsKey(currentDiff))
						{
							List<List<int>> pairs = new List<List<int>>();
							List<int> pair = new List<int>() { i, j };
							pairs.Add(pair);
							dicti[currentSum] = pairs;
						}
						else
						{
							foreach (List<int> pair in dicti[currentDiff])
							{
								foreach (List<int> sec_pair in dicti[currentSum])
								{
									int[] output = new int[4] { pair[0], pair[1], sec_pair[0], sec_pair[1] };
									quads.Add(output);
								}
							}

						}
					}
				}
			}
			return quads;
		}

	}
}
