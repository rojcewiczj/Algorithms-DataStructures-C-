using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class Denominations
    {
		public static int NumberOfWaysToMakeChange(int n, int[] denoms)
		{
			int[] ways = new int[n + 1];
			ways[0] = 1;
			foreach (int denom in denoms)
			{
				Console.WriteLine("denom: {0}", denom);
				for (int amount = 1; amount < n + 1; amount++)
				{
					Console.WriteLine("amount: {0}", amount);
					if (denom <= amount)
					{
						ways[amount] += ways[amount - denom];
						Console.WriteLine("current ways: {0}", ways[amount]);
					}
				}
			}
			return ways[n];
		}
	}
}
