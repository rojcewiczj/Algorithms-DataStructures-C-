using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace AlgorithmsCsharp.Graphs
{
    class Graph
    {
        public int[,] _nodes;

        public Dictionary<int, List<int>> _connections;


        public Graph()
        {
            _connections = new Dictionary<int, List<int>>();
            Random rnd = new Random();
            _nodes = new int[9, 9];

            for (int i = 1; i < 8; i++)
            {
                _nodes[i, i] = i;
                _nodes[i, i + 1] = rnd.Next(1, 9);
                Console.WriteLine("{0}, {1}", _nodes[i, i], _nodes[i, i + 1]);

                if (!_connections.ContainsKey(_nodes[i, i]))
                {
                    _connections[_nodes[i, i]] = new List<int>();
                    _connections[_nodes[i, i]].Add(_nodes[i, i + 1]);

                }
                else
                {
                    _connections[_nodes[i, i]].Add(_nodes[i, i + 1]);
                }
                if (!_connections.ContainsKey(_nodes[i, i + 1]))
                {
                    _connections[_nodes[i, i + 1]] = new List<int>();
                    _connections[_nodes[i, i + 1]].Add(_nodes[i, i]);
                }
                else
                {
                    _connections[_nodes[i, i + 1]].Add(_nodes[i, i]);
                }



            }
            Console.WriteLine(" ");
         foreach(KeyValuePair<int, List<int>> entry in _connections)
            {
                Console.Write("{0} : ", entry.Key);
                foreach (var el in entry.Value)
                {
                    Console.Write("{0} ", el);
                }
                Console.WriteLine(" ");
            }

        }
    }
}
