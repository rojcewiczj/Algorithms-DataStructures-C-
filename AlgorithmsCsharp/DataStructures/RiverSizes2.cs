using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    public class RiverSizes2
    {
        public static int[,] matrix = new int[4, 4];

        public static List<int> find() {
            List<int> sizes = new List<int>();
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    visited[x, y] = false;
                }
            }

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (!visited[x, y]) { 
                        traverseNode(x, y, matrix, visited, sizes);
                    }
                }


            }
            return sizes;
        }

        public static void traverseNode(int x, int y, int[,] matrix, bool[,] visited, List<int> sizes)
        {
            int currentRiverSize = 0;
            Stack<List<int>> nodesToExplore = new Stack<List<int>>();
            List<int> firstToExplore = new List<int>() { x, y };
            nodesToExplore.Push(firstToExplore);
            while(nodesToExplore.Count > 0)
            {
                List<int> currentNode = nodesToExplore.Pop();
                x = currentNode[0];
                y = currentNode[1];
                if (!visited[x, y])
                    visited[x, y] = true;
                    if (matrix[x,y] == 1)
                    {
                    currentRiverSize += 1;
                    List<List<int>> unvisitedNeighbors = getUnvisitedNeighbors(x, y,  matrix, visited);
                    foreach(List<int> neighbor in unvisitedNeighbors)
                        {
                        nodesToExplore.Push(neighbor);
                        }
                    }


            }

            if (currentRiverSize > 0)
            {
                sizes.Add(currentRiverSize);
            }


        }

        public static List<List<int>> getUnvisitedNeighbors(int x, int y, int[,] matrix, bool[,] visited)
        {
            List<List<int>> unvisitedNeighbors = new List<List<int>>();
            if (x > 0 && !visited[x - 1, y])
            {
                unvisitedNeighbors.Add(new List<int>() { x - 1, y });
            }
            if (x < matrix.GetLength(0) - 1 && !visited[x + 1, y])
            {
                unvisitedNeighbors.Add(new List<int>() { x + 1, y });
            }
            if (y > 0  && !visited[x , y -1])
            {
                unvisitedNeighbors.Add(new List<int>() { x , y - 1});
            }
            if (y < matrix.GetLength(1) - 1 && !visited[x , y + 1])
            {
                unvisitedNeighbors.Add(new List<int>() { x , y + 1 });
            }

            return unvisitedNeighbors;

        }
    }
}
