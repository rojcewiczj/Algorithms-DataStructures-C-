using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MaxSumPermutations
    {
        public static List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6 };

        public static int[,] requests = new int[,] {{ 0, 1} };
        public static void Find()
        {

            Dictionary<int, List<int>> index_priorities = new Dictionary<int, List<int>>();
            Dictionary<int, int> freq = new Dictionary<int, int>();
            Dictionary<int, int> order = new Dictionary<int, int>();
            List<int> empty_list = new List<int>();
            index_priorities[0] = empty_list;
            List<int> priority_list = new List<int>();
            List<int> final_list = new List<int>();
            int total_sum = 0;

            for (int i = 0; i < requests.Length / 2; i++)
            {
                for (int j = requests[i, 0]; j <= requests[i, 1]; j++)
                {

                    if (freq.ContainsKey(j))
                    {
                        freq[j] += 1;
                        int frequency = freq[j];
                        index_priorities[frequency - 1].Remove(j);
                        if (index_priorities[frequency - 1].Count == 0)
                        {
                            index_priorities.Remove(frequency - 1);
                        }
                        if (index_priorities.ContainsKey(frequency))
                        {
                            index_priorities[frequency].Add(j);

                        }
                        else
                        {
                            List<int> new_list = new List<int> { j };
                            index_priorities[frequency] = new_list;
                        }
                    }
                    else
                    {
                        freq[j] = 1;
                        if (index_priorities.ContainsKey(1))
                        {
                            index_priorities[1].Add(j);
                        }
                        else
                        {
                            List<int> new_list = new List<int> { j };
                            index_priorities[1] = new_list;
                        }
                    }

                }

            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (!freq.ContainsKey(i))
                {
                    index_priorities[0].Add(i);
                    priority_list.Add(0);

                }
                else
                {
                    priority_list.Add(freq[i]);
                }

            }

            priority_list.Sort();
            arr.Sort();

            for (int i = arr.Count() - 1; i > -1; i--)
            {

                while (index_priorities[priority_list[i]].Count > 0)
                {
                    int assign = index_priorities[priority_list[i]][0];
                    index_priorities[priority_list[i]].RemoveAt(0);
                    order[assign] = arr[i];
                    break;
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                final_list.Add(order[i]);
            }

            for (int i = 0; i < requests.Length / 2; i++)
            {
                for (int j = requests[i, 0]; j <= requests[i, 1]; j++)
                {
                    total_sum += final_list[j];
                }
            }


            Console.WriteLine(total_sum);
        }

    }

   
}
