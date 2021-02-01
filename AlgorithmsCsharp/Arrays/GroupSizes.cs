using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class GroupSizes
    {
        public static int[] groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };

        public static IList<IList<int>> Find()
        {
            IList<IList<int>> output = new List<IList<int>>();
            Dictionary<int, List<int>> dicti = new Dictionary<int, List<int>>();

            for (int i = 0; i < groupSizes.Length; i++)
            {   
                
               

                if (!dicti.ContainsKey(groupSizes[i]))
                {
                    
                    dicti[groupSizes[i]] = new List<int>{ i };

                    if(dicti[groupSizes[i]].Count == groupSizes[i]) {

                        output.Add(dicti[groupSizes[i]]);
                        dicti[groupSizes[i]] = new List<int>();

                    }
                }
                else
                {
                    if (dicti[groupSizes[i]].Count < groupSizes[i])
                    {
                        
                        dicti[groupSizes[i]].Add(i);
                        Console.WriteLine(i);
                    }
                    if(dicti[groupSizes[i]].Count == groupSizes[i])
                    {
                        output.Add(dicti[groupSizes[i]]);
                        dicti[groupSizes[i]] = new List<int>();
                    }

                }
            }
        
            return output;
        }

    }
}
