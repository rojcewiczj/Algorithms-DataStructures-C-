using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public static class GraphTraversal
    {

       public static int[,] connections = new int[,] { { 1, 2 }, { 2, 3 }, { 3, 2 } };

       public static List<int> Traverse()
        {
            List<List<int>> queue = new List<List<int>>();
            List<int> first_node = new List<int>() { 0 };
            queue.Add(first_node);
            List<int> visited = new List<int>();
            while (queue.Count > 0)
            {
                List<int> path = queue[0];
                queue.RemoveAt(0);
                int currentNode = path[path.Count - 1];
                path.RemoveAt(path.Count - 1);
                visited.Add(currentNode);


            }
            
        }
    }
}
