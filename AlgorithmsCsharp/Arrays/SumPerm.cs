using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class SumPerm
    {
        public static List<int> arr = new List<int>{ 1,2,3,4,5 };

        public static int[,] requests = new int[,] { { 1,3 }, { 0,1 } };

        public static void Find()
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            Dictionary<int, List<int>> rev_freq = new Dictionary<int, List<int>>();
        
            List<int> occurances = new List<int>();
            
            for(int i = 0; i < requests.Length / 2; i++) {

                for (int j = requests[i, 0]; j <= requests[i, 1]; j++)
                {

                    if (!freq.ContainsKey(j))
                    {
                        List<int> indexes = new List<int> { j };
                        freq[j] = 1;
                        rev_freq[1] = indexes;
                    }
                    else
                    {
                        
                        freq[j] += 1;
                        rev_freq[freq[j] - 1].Remove(j);
                        if (rev_freq.ContainsKey(freq[j])) { 
                        rev_freq[freq[j]].Add(j);
                        }
                        else
                        {
                            List<int> indexes = new List<int> { j };
                            rev_freq[freq[j]] = indexes;
                        }
                        
                    }
                   
                    
                }
            }

            foreach(KeyValuePair<int,int>kvp in freq)
            {
                if (!occurances.Contains(kvp.Value)){
                    occurances.Add(kvp.Value);
                }
            }

            occurances.Sort();

           

            int k = occurances.Count - 1;
            int a = arr.Count - 1;
            Stack<int> stack = new Stack<int>();
            Stack<int> remaining_indexs = new Stack<int>();
            Stack<int> remaining_nums = new Stack<int>();
            while(a > - 1)
            {
                if(k > -1) { 
                    foreach(int index in rev_freq[occurances[k]])
                    {
                        stack.Push(index);
                    }
                }
                if(stack.Count > 0) { 
                int index_switch = stack.Pop();
                int num_to_switch = arr[index_switch];
                    remaining_indexs.Push(a);
                    remaining_nums.Push(arr[a]);
                arr[index_switch] = arr[a];
            
                k -= 1;
                a -= 1;
                }
                else
                {
                    break;
                }
            }
            while(remaining_indexs.Count > 0)
            {
                arr[remaining_indexs.Pop()] = remaining_nums.Pop();
            }
           foreach(int num in arr)
            {
                Console.WriteLine(num);
            }

        }
    }
}
