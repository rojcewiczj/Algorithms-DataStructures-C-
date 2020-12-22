using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class WaterJug
    {
        public static int X = 2;
        public static int Y = 6;
        public static int Z = 5;
       

        public static void Measure()
        {
            Console.WriteLine(X);
            int Total_cap = X + Y;
            if (Total_cap / 2 == Z)
            {
                Console.WriteLine("true");
            }
            else if( X == Z || Y == Z)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
