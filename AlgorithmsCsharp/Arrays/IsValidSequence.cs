using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class IsValidSequence
    {

		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			int i = 0;
			int j = 0;

			while (j < sequence.Count && i < array.Count)
			{
				if (array[i] == sequence[j])
				{
					j++;
				}
				i++;
			}
			return j == sequence.Count;


		}
	}

}

