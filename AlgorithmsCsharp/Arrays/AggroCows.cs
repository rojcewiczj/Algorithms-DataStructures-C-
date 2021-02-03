using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class AggroCows
    {
        public static int[] stalls = new int[] {12,34,40,42,46 };

        public static int cows = 3;


        public static int Max_distance()
        {  // 12,34,40,42
         
            int mid = 0;
            Array.Sort(stalls);   
            int low = 1;
            int max = stalls[stalls.Length -1] -1;
            while(low + 2< max)
            {
                mid = (low + max) / 2;
                Console.WriteLine("low {0}",low);
                Console.WriteLine("max {0}",max);
                Console.WriteLine("mid {0}",mid);
                if (!works(mid))
                {
                    max = mid ;
                }
                else
                {
                   low = mid -1;
                }
            }





            return mid;
        }

        public static bool works(int mid)
        {
            int count = cows -1;
            int last_position = 0;
            for(int i = 1; i < stalls.Length; i++)
            {
                if(stalls[i] - stalls[last_position] >= mid)
                {
                    Console.WriteLine(" i : {0}", stalls[i]);
                    Console.WriteLine("last_position : {0}", stalls[last_position]);
                    count -= 1;
                    last_position = i;
                }
                
            }
            Console.WriteLine("count {0}", count);
            if (count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
