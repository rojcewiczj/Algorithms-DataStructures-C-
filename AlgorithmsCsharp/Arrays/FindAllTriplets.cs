using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class FindAllTriplets
    {
        public static List<int> list = new List<int> { 1,2,4,8,16,32,64,64,64,64,64,64 };

        public static int n = 2;
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
                   
                    firstCheck = true;
                }
                if (After.ContainsKey(current * n))
                {
                    
                    thirdCheck = true;
                }
                if(firstCheck && thirdCheck)
                {
                    int k = 0;
                    int j = 0;
                    List<int> first = Before[current / n];
                    List<int> third = After[current * n];

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
