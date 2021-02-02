using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class Bananas
    {
        public static int[] piles = { 3, 6, 7, 11 };

        public static int H = 8;


        public static int MinEatingSpeed()
        {

           
            int min = 1;
            int max = 1000000000;
            int mid = 0;
            while(min < max)
            {
                mid = (min + max) / 2;
                if(!possible(piles, H, mid))
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }


        




            return min;
           
        }

        public static bool possible(int[] piles, int H, int mid)
        {
            
           int count = 0;
           foreach(int pile in piles)
            {
                int current = pile;
                while(current > 0)
                {
                    current -= mid;
                    count += 1;
                }
            }
         
           if (count > H)
            {
                return false;
            }
            return true;
        }
    }
}
