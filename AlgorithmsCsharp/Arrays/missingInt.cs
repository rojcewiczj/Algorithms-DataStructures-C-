using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class missingInt
    {
        public static int[] arr = new int[] {5,3,8,6,2,1,9,10,7};

        public static int sum = 12;
        public static List<List<int>> Find()
        {
            List<List<int>> pairs = new List<List<int>>();
            Dictionary<int, int> check = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!check.ContainsKey(sum - arr[i]))
                {
                    check[arr[i]] = 1;
                }
                else
                {
                    List<int> pair = new List<int> { sum - arr[i], arr[i] };
                    pairs.Add(pair);
                }                    
            }

            foreach(List<int> pair in pairs)
            {
                Console.WriteLine("");
                foreach (int num in pair)
                {
                    Console.Write(" {0} ", num);
                }
                Console.WriteLine("");
            }



            return pairs;


        }
    }
}
