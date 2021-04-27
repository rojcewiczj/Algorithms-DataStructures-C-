using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    public class MergingSubArrays
    {
		public int[][] MergeOverlappingIntervals(int[][] intervals)
		{
			int[][] sortedIntervals = intervals.Clone() as int[][];
			Array.Sort(sortedIntervals, (a, b) => a[0].CompareTo(b[0]));

			List<int[]> mergedIntervals = new List<int[]>();
			int[] currentInterval = sortedIntervals[0];
			mergedIntervals.Add(currentInterval);

			foreach (var nextInterval in sortedIntervals)
			{
				int currentIntervalEnd = currentInterval[1];
				int nextIntervalStart = nextInterval[0];
				int nextIntervalEnd = nextInterval[1];

				if (currentIntervalEnd >= nextIntervalStart)
				{
					currentInterval[1] = Math.Max(currentIntervalEnd, nextIntervalEnd);
				}
				else
				{
					currentInterval = nextInterval;
					mergedIntervals.Add(currentInterval);
				}
			}
			return mergedIntervals.ToArray();
		}
	}
}
