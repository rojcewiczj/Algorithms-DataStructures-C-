using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace AlgorithmsCsharp.Hourglass
{
    class HourGlassAdder
    {
        public int[,] data;
        public int Max;
        public HourGlassAdder()
        {
            System.Random random = new System.Random();
            data = new int[6, 6];
            for (int x = 0; x < 6; x++)
            {
                
                for (int y = 0; y < 6; y++)
                {
                    data[x, y] = random.Next(0, 9);
                    Console.Write(String.Format(" {0} ", data[x, y]));

                }
                Console.WriteLine();
            }
        }
        public int FindMax()
        {
            List<int> sums = new List<int>();
            for (int x = 1; x < 5; x++)
            {

                for (int y = 1; y < 5; y++)
                {
                    int sum = data[x - 1, y - 1] + data[x - 1, y] + data[x - 1, y + 1]
                                             + data[x, y] +
                                  data[x + 1, y - 1] + data[x + 1, y] + data[x + 1, y + 1];
                    sums.Add(sum);

                }
                
                
            }
            return sums.Max();
        }

    }
}
