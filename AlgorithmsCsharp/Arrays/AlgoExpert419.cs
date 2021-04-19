﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class AlgoExpert419
    {
		public static int NumberOfWaysToMakeChange(int n, int[] denoms)
		{
			int[] ways = new int[n + 1];
			ways[0] = 1;

			foreach (int denom in denoms)
			{
				for (int amount = 1; amount < n + 1; amount++)
				{
					if (denom <= amount)
					{
						ways[amount] += ways[amount - denom];
					}
				}
			}

			return ways[n];
		}
	}
}
