using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MaxSumPermutations
    {
        public static List<int> arr = new List<int> { 1, 2, 3, 4, 5, 10 };

        public static int[,] requests = new int[,] { { 0,2 }, { 1,3 }, { 1, 1} };
        public static void Find()
        {

            Dictionary<int, int> index_freq = new Dictionary<int, int>();
            List<int> priority_list = new List<int>();

            for(int i = 0; i < requests.Length / 2; i++)
            {
                for(int j = requests[i,0]; j < requests[i,1] +1; j++)
                {
                    if (index_freq.ContainsKey(j))
                    {
                        index_freq[j] += 1;
                    }
                    else
                    {
                        index_freq[j] = 1;
                    }
                }

            }
            for(int i = 0; i < arr.Count(); i++)
            {
                if (index_freq.ContainsKey(i))
                {
                    priority_list.Add(index_freq[i]);
                }
                else
                {
                    priority_list.Add(0);
                }
                Console.WriteLine("priority = {0} / arr_val {1}", priority_list[i], arr[i]);
            }
            

            

           

        }


    }

   
}
