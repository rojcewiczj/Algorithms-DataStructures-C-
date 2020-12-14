using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MakeDivisible
    {
       public static int [] nums = { 6, 3, 5, 2,2,2,9,12,2};
       public static int P = 9;



        public static void MakeDiv()
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;

            }
            if (sum % P == 0)
            {
                Console.Write("yep");
            }
            else
            {  
                List<int> sub_array = new List<int>();
                int sub_total = 0;
                int k = 1;
                while ((sum - sub_total) % P != 0 && k < (nums.Length - 1))
                {

                    sub_array = new List<int>();
                    for (int i = 0; i < k; i++)
                    {
                        sub_total += nums[i];
                        sub_array.Add(nums[i]);
                    }
                    if ((sum - sub_total) % P == 0)
                    {
                       break;
                    }

                    for (int i = k; i < nums.Length; i++)
                    {

                        sub_total = (sub_total - nums[i - k]) + nums[i];
                        sub_array.Remove(nums[i - k]);
                        sub_array.Add(nums[i]);
                        foreach (int num in sub_array)
                        {
                            
                        }
                        if ((sum - sub_total) % P == 0)
                        {
                            break;
                        }

                    }
                    
                    if ((sum - sub_total) % P == 0)
                    {
                        break;
                    }
                    
                    k += 1;

                }
                if(sub_array.Count > 0)
                {
                    foreach(int num in sub_array)
                    {
                        Console.WriteLine(num);
                    }
                }
               
                   
                   
                
            }
        }
    }
}
