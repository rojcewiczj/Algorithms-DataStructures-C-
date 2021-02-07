using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class ThreeLargest
    {

		public static int[] FindThreeLargestNumbers(int[] array)
		{
			// Write your code here
			int[] ThreeLargest = new int[3];
			for (int i = 0; i < array.Length; i++)
			{
				Update(ThreeLargest, array[i]);
			}
			return ThreeLargest;
		}

		public static void Update(int[] largest, int num)
		{
			if (num > largest[2])
			{
				Shift(largest, num, 2);
			}
			else if (num > largest[1])
			{
				Shift(largest, num, 1);
			}
			else if (num > largest[0])
			{
				Shift(largest, num, 0);
			}

		}
		public static void Shift(int[] threeLargest, int num, int index)
		{
			for (int i = 0; i <= index; i++)
			{
				if (i == index)
				{
					threeLargest[i] = num;
				}
				else
				{
					threeLargest[i] = threeLargest[i + 1];
				}
			}

		}
	}
}

