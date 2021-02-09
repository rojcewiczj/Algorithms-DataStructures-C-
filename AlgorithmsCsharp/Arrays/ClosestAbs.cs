using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class ClosestAbs
    {
		public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
		{
			Array.Sort(arrayOne);
			Array.Sort(arrayTwo);
			int i = 0;
			int j = 0;
			int smallest = 999999;
			int[] output = new int[2];

			while (i < arrayOne.Length && j < arrayTwo.Length)
			{
				int current_abs = Math.Abs(arrayOne[i] - arrayTwo[j]);
				if (current_abs == 0)
				{
					output = new int[] { arrayOne[i], arrayTwo[j] };
					return output;
				}
				if (current_abs < smallest)
				{
					smallest = current_abs;
					output = new int[] { arrayOne[i], arrayTwo[j] };
				}
				if (arrayOne[i] < arrayTwo[j])
				{
					i += 1;
				}
				else if (arrayTwo[j] < arrayOne[i])
				{
					j += 1;
				}
			}

			return output;
		}
	}
}
