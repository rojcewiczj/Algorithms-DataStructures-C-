using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public static class AlgosBuyAndSell
    {
		public static int BuyAndSell(int[] prices)
		{
			int profit = 0;
			int buy = prices[0];
			int sell = prices[0];

			foreach (int price in prices)
			{
				if (price < buy) { 
					buy = price;
				    sell = 0;
			}
		  else if ((price - buy) > profit)
			{
				sell = price;
				profit = (price - buy);
			}
		}
		return profit;
	}
}
}
