using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
     class Heaters
    {
        public static int[] houses = new int[] {3,5,19,30 };

        public static int[] heaters = new int[] {1};

        public static int minRadius()
        {
            int final_radius = 0;
            Array.Sort(houses);
            Array.Sort(heaters);
            int i = 0;
            int left;
            int right;


            foreach (int house in houses)
            {
                while (i < heaters.Length - 1 && heaters[i] <= house)
                {
                    i++;
                }

                if (i > 0)
                {
                    left = Math.Abs(house - heaters[i - 1]);
                }
                else
                {
                    left = Math.Abs(house - heaters[0]);
                }
                right = Math.Abs(heaters[i] - house);
                final_radius = Math.Max(final_radius, Math.Min(left, right));


            }

            return final_radius;

    }
    }
}
