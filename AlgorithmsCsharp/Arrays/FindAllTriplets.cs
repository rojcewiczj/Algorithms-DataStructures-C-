using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class FindAllTriplets
    {
        public static List<int> list = new List<int> { 1,3,9,9,27,81 };

        public static int n = 3;
        public static void Find()
        {
            Dictionary<int, List<int>> Before = new Dictionary<int, List<int>>();

            Dictionary<int, List<int>> After = new Dictionary<int, List<int>>();

            List<List<int>> Triplets = new List<List<int>>();


            for (int i = 2; i < list.Count; i++)
            {
                if (!After.ContainsKey(list[i]))
                {
                    List<int> indexes = new List<int>();
                    indexes.Add(i);
                    After[list[i]] = indexes;
                }
                else
                {
                    After[list[i]].Add(i);
                }
            }
            

            for (int i = 1; i < list.Count; i++)
            {   
                bool firstCheck = false;
                bool thirdCheck = false;

                List<int> first = new List<int>();
                List<int> third = new List<int>();

                if (!Before.ContainsKey(list[i - 1]))
                {   
                    List<int> indexes = new List<int>();
                    indexes.Add(i -1);
                    Before[list[i - 1]] = indexes;
                }
                else
                {
                    Before[list[i - 1]].Add(i - 1);
                }
                int current = list[i];
                if (Before.ContainsKey(current / n))
                {   
                    foreach(int index in Before[current / n]) { 
                    first.Add(index);
                    }
                    firstCheck = true;
                }
                if (After.ContainsKey(current * n))
                {
                    foreach (int index in After[current * n])
                    {
                        third.Add(index);
                    }
                    thirdCheck = true;
                }
                if(firstCheck && thirdCheck)
                {
                    int k = 0;
                    int j = 0;

                    while(k < first.Count)
                    {
                        int first_one = first[k];
                        while (j < third.Count)
                        {
                            List<int> new_triplet = new List<int>();
                            int third_one = third[j];
                            new_triplet.Add(first_one);
                            new_triplet.Add(i);
                            new_triplet.Add(third_one);
                            Console.WriteLine("{0}, {1}, {2}", first_one, i, third_one);
                            Triplets.Add(new_triplet);
                            j++;
                        }
                        j = 0;
                        k++;
                        

                    }
                    
                    
                   
                }
                

            }



        }



    }
}
