using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MinJumps
    {
        public static int[] forbidden = { 14, 4, 18, 1, 15 };

        public static int a = 3;

        public static int b = 15;

        public static int x = 9;


        public static void jumps()
        {
            List<int> list = new List<int>();

            int i = 0;

            while (i != x)
            {
                while (i < x)
                {
                    i += a;
                    list.Add(i);
                }
                while (i > x)
                {
                    i -= b;
                    list.Add(i);
                }
            }
            foreach(int step in list)
            {
                Console.Write("- {0} ", step);
            }

        }

    }
}
