using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    public static class AlgoPractice4_26
    {
		public static List<int> RiverSizes(int[,] matrix)
		{
			List<int> sizes = new List<int>();
			bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (visited[i, j])
					{
						continue;
					}
					traverse(i, j, matrix, visited, sizes);
				}
			}
			return sizes;
		}

		public static void traverseNode(int i, int j, int[,] matrix, bool[,] visited, List<int> sizes)
		{
			int currentRiverSize = 0;
			Stack<int[]> nodesToExplore = new Stack<int[]>();
			nodesToExplore.Push(new int[] { i, j });
			while (nodesToExplore.Count != 0)
			{
				int[] currentNode = nodesToExplore.Pop();
				i = currentNoe[0];
				j = currentNode[1];
				if (visited[i, j])
				{
					continue;
				}
				visited[i, j] = true;
				if (matrix[i, j] == 0)
				{
					continue;
				}
				currentRiverSize++;
				List<int[]> unvisitedNeighbors = getUnvisitedNeighbors(i, j, matrix, visited)
				foreach (var neighbor in unvisitedNeighbors)
				{
					nodesToExplore.Push(neighbor);
				}
			}
			if (currentRiverSie > 0)
			{
				sizes.Add(currentRiverSize);
			}
		}

		public static List<int[]> getUnvisitedNeighors(int i, int j, int[,] matrix, bool[,] visited)
		{
			List<int> unvisitedNeighbors = new List<int[]>();
			if (i > 0 && !visited[i - 1, j])
			{
				unvisitedNeighbors.Add(new int[] { i - 1 }, j)
			}
			return unvisitedNeighbors;
		}
	}
}
