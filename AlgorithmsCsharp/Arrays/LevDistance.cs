using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
	public class LevDistance
	{
		public string str1;

		public string str2;

		public LevDistance(string _str1, string _str2)
		{
			str1 = _str1;
			str2 = _str2;
		}
		public int LevenshteinDistance()
		{
			int[,] edits = new int[str2.Length + 1, str1.Length + 1];
			for (int i = 0; i < str2.Length + 1; i++)
			{
				for (int j = 0; j < str1.Length + 1; j++)
				{
					edits[i, j] = j;
				}
				edits[i, 0] = i;
			}
			for (int i = 1; i < str2.Length + 1; i++)
			{
				for (int j = 1; j < str1.Length + 1; j++)
				{
					if (str2[i - 1] == str1[j - 1])
					{
						edits[i, j] = edits[i - 1, j - 1];
					}
					else
					{
						edits[i, j] = 1 + Math.Min(edits[i - 1, j - 1], Math.Min(edits[i - 1, j], edits[i, j - 1]));
					}
				}
			}
			return edits[str2.Length, str1.Length];
		}
	}
}
