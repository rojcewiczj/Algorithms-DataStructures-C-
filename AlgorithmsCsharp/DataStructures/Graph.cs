using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class Graph
    {
        public Dictionary<string, List<string>> AdjecList = new Dictionary<string, List<string>>();



        public void Add(string first, string second)
        {

            List<string> nodeList = new List<string> { first, second };

            foreach (string node in nodeList)
            {
                if (AdjecList == null || !AdjecList.ContainsKey(node))
                {
                    List<string> newList = new List<string>();
                    if (nodeList.IndexOf(node) == 0)
                    {
                        newList.Add(nodeList[1]);
                    }
                    else
                    {
                        newList.Add(nodeList[0]);
                    }
                    AdjecList.Add(node, newList);
                }
                else
                {
                    if (nodeList.IndexOf(node) == 0)
                    {
                        AdjecList[node].Add(nodeList[1]);
                    }
                    else
                    {
                        AdjecList[node].Add(nodeList[0]);
                    }
                }
            }
        }

        public void removeEdge(string first, string second)
        {
            for (int i = 0; i < AdjecList[first].Count; i++)
            {
                if (AdjecList[first][i] == second)
                {
                    AdjecList[first].RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < AdjecList[second].Count; i++)
            {
                if (AdjecList[second][i] == first)
                {
                    AdjecList[second].RemoveAt(i);
                    break;
                }
            }
        }

        public void removeNode(string node)
        {

            foreach (KeyValuePair<string, List<string>> kvp in AdjecList)
            {
                Console.WriteLine("");
                Console.Write(" {0} : [ ", kvp.Key);
                foreach (string val in kvp.Value)
                {

                    if (val == node)
                    {
                        kvp.Value.RemoveAt(kvp.Value.IndexOf(val));
                    }

                }

            }
            AdjecList.Remove(node);

        }

        public void print()
        {
            foreach (KeyValuePair<string, List<string>> kvp in AdjecList)
            {
                Console.WriteLine("");
                Console.Write(" {0} : [ ", kvp.Key);
                foreach (string node in kvp.Value)
                {

                    Console.Write(" {0}, ", node);
                }
                Console.Write(" ]");
                Console.WriteLine(" ");
            }
        }

        public void traversal(string start, string end)
        {
            List<string> path = new List<string>();
            path.Add(start);
            Queue<List<string>> queue = new Queue<List<string>>();
            queue.Enqueue(path);
            bool end_not_found = true;

            while (end_not_found)
            {
            
                path = queue.Dequeue();
                string last_node = path[path.Count - 1];
              
                if(last_node == end)
                {
                    end_not_found = false;
                }
                foreach (string connection in AdjecList[last_node])
                {
                   
                    if (!path.Contains(connection))
                    {
                     
                        List<string> new_path = new List<string>();
                        foreach (string steps in path)
                        {
                            new_path.Add(steps);
                        }
                        new_path.Add(connection);
                        queue.Enqueue(new_path);
                        break;
                    }
                }
          
            }
            foreach(string step in path)
            {
                Console.WriteLine(step);
            }

        }
    }
}
