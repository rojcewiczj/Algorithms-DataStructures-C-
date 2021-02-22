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

        public static traverseNode(int x, int y, int[,] matrix, List<int> sizes)
        {
            int currentRiverSize = 0;
            List<List<int>> nodesToExplore = new List<List<int>>();
            List<int> firstToExplore = new List<int>() { x, y };
            nodesToExplore.Add(firstToExplore);


        }
    }
}
