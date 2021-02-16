using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    public class RiverSizes
    {
        public static int[,] matrix = new int[,] { { 1, 0, 0, 1, 0 }, { 1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 0 } };

        public static List<int> RiverSizesFind()
        {
            List<int> output = new List<int>();
            Dictionary<string, List<string>> connections = new Dictionary<string, List<string>>();

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {

                    string up = null;
                    string down = null;
                    string left = null;
                    string right = null;
                    List<string> directions = new List<string>() { up, down, left, right };
                    connections[$"{x}{y}"] = new List<string>();
                    if (x > 0)
                    {
                        directions[0] = $"{x - 1}{y}";
                    }
                    if (x <= matrix.GetLength(0) - 2)
                    {
                        directions[1] = $"{x + 1}{y}";
                    }
                    if (y > 0)
                    {
                        directions[2] = $"{x}{y - 1}";
                    }
                    if (y <= matrix.GetLength(1) - 2)
                    {
                        directions[3] = $"{x}{y + 1}";
                    }

                    foreach (string dir in directions)
                    {
                        if (dir != null)
                        {
                            connections[$"{x}{y}"].Add(dir);
                        }
                    }

                }

            }
          

            return Traverse(connections);

        }
        public static int ToInt(char c)
        {
            return (int)(c - '0');
        }

        public static List<int> Traverse(Dictionary<string, List<string>> connections)
        {
            List<int> sizes = new List<int>();
            List<string> path = new List<string>();
            List<string> visited = new List<string>();
            path.Add("00");
            Queue<List<string>> queue = new Queue<List<string>>();
            queue.Enqueue(path);
            int size = 0;
            while (queue.Count > 0)
            {
                List<string> current_path = queue.Dequeue();
                string location = current_path[current_path.Count - 1];
                visited.Add(location);
                if (matrix[ToInt(location[0]), ToInt(location[1])] != 1)
                {
                    if (size > 0)
                    {
                        sizes.Add(size);
                    }
                    size = 0;
                    foreach (string neighbor in connections[location])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            List<string> new_path = path;
                            new_path.Add(neighbor);
                            queue.Enqueue(new_path);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (string neighbor in connections[location])
                    {
                        size += 1;
                        if (!visited.Contains(neighbor) && matrix[ToInt(neighbor[0]), ToInt(neighbor[1])] == 1)
                        {
                            List<string> new_path = path;
                            new_path.Add(neighbor);
                            queue.Enqueue(new_path);
                            break;
                        }

                    }


                }


            }

            return sizes;


        }
    }
}
