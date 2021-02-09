using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class Monotonic
    {
		public static bool IsMonotonic(int[] array)
		{
			// Write your code here.
			bool up = false;
			bool down = false;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < array[i - 1])
				{
					down = true;
					if (up == true)
					{
						return false;
					}
				}
				if (array[i] > array[i - 1])
				{
					up = true;
					if (down == true)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
