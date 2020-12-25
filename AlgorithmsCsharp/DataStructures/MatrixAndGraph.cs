using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class MatrixAndGraph
    {

        public int[,] matrix;

        public int _x;

        public int _y;

        public Dictionary<string, List<string>> connections = new Dictionary<string, List<string>>();


        public List<string> neighbors(int ex, int why)
        {
            List<string> neigh = new List<string>();
            for (int x = ex + 1; x > ex - 2 && x > -1 && x < _x + 1; x--)
            {
                for (int y = why + 1; y > why - 2 && y > -1 && y < _y + 1;)
                    neigh.Add(string.Format("{0},{1}", x, y));

            }
            return neigh;

        }
        public MatrixAndGraph(int X, int Y)
        {
            Console.WriteLine("bleep");
            _x = X;

            _y = Y;

            matrix = new int[X, Y];

            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {

                    connections[string.Format("{0},{1}", x, y)] = neighbors(x, y);
                }


            }



        }
    }
}
