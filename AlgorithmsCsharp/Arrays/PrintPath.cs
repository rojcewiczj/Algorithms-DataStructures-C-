using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class PrintPath
    {
        public static List<List<string>> Matrix = new List<List<string>>();

        public static int n = 10;


        public static void insert()
        {
            for (int i = 0; i < n; i++)
            {
                List<string> row = new List<string>();
                Matrix.Add(row);
                for (int j = 0; j < n; j++)
                {
                    if (i != 9 && j == 4)
                    {
                        Matrix[i].Add("X");
                    }
                    else
                    {
                        Matrix[i].Add(".");
                    }
                    Console.Write(" {0} ", Matrix[i][j]);
                }

                Console.WriteLine("");
            }
        }

        public static void traverse()
        {

        }


    }
}
