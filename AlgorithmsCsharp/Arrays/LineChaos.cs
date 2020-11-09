using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class LineChaos
    {
        public int[] _line;

        public LineChaos(int[] line)
        {
            _line = line;
        }

        public int CountSteps()
        {
            List<int> InitialState = new List<int>();

            int i = _line.Length - 1;
            int steps = 0;
            while(i > -1)
            {
                if (_line[i] > i + 1)
                {
                    steps += _line[i] - (i + 1);
                }
                i -= 1;
            }

            return steps;
        }
    }
}
