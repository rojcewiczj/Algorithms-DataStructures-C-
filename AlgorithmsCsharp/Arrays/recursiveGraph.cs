using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class recursiveGraph
    {
        public  int _width;

        public  int _height;

        public recursiveGraph(int width, int height)
        {
            _width = width;
            _height = height;

        }

        public int NumberOfWaysToTraverseGraph(int width, int height)
        {
            if (width == 1 || height == 1)
            {
                return 1;
            }
            return NumberOfWaysToTraverseGraph(width - 1, height) + NumberOfWaysToTraverseGraph(width, height - 1);

        return -1;
        }

    }
}
