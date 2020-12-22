using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.ValidString
{
    class AdditiveSequence
    {
        public static string num = "112358";

        public static bool CanAdd()
        {

            int i = 0;
            
           
            while (i < num.Length - 2)
            {
                Console.WriteLine(num[i]);

                if ((int)(num[i] - '0') + (int)(num[i + 1] - '0') != (int)(num[i + 2] - '0'))
                {
                    return false;
                }
                i += 1;
                
            }

            return true;
        }

    }
}
