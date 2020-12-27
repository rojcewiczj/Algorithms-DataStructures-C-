using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class MatrixAndGraph
    {

        public List<List<int>> matrix = new List<List<int>>();

        public int _x;

        public int _y;

        public Dictionary<string, List<string>> connections = new Dictionary<string, List<string>>();


        public List<string> Trip(string start, string end)
        {
         
            List<string> visited = new List<string>();
            List<string> path = new List<string> { start };
            Queue<List<string>> queue = new Queue<List<string>>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                string local = path[path.Count - 1];
                if(local == end)
                {
                    return path;
                   
                }
                if (!visited.Contains(local))
                {
                    visited.Add(local);
                    foreach (string location in connections[local])
                    {
                       
                        if (!visited.Contains(location))
                        {
                            List<string> new_path = new List<string>();
                            foreach (string node in path)
                            {
                                new_path.Add(node);
                            }
                            new_path.Add(location);
                            queue.Enqueue(new_path);
                            break;
                        }
                    }
                }
            }
            return path;

        }
        public List<string> neighbors(int ex, int why)
        {
            
            List<string> neigh = new List<string>();
            for (int x = ex + 1; x > ex - 2 && x > -1 && x < _x + 1; x--)
            {   
                
            
                for (int y = why + 1; y > why - 2 && y > -1 && y < _y + 1; y--) {
                    string formatted = string.Format("{0},{1}", x, y);
                    if (formatted != string.Format("{0},{1}", ex, why)) { 
                    neigh.Add(formatted);
                    }
              }

            }
            return neigh;

        }
        public MatrixAndGraph(int X, int Y)
        {
            _x = X;

            _y = Y;

            

            for (int x = 0; x < X; x++)
            {
                List<int> row = new List<int>();
                for (int y = 0; y < Y; y++)
                {
                    row.Add(0);
                  
                    string new_key = string.Format("{0},{1}", x, y);
                    List<string> new_neigh = neighbors(x, y);
                    connections[new_key] = new_neigh;
                }
                matrix.Add(row);


            }



        }
    }
}
