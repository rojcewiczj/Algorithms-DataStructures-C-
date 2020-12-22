using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.ValidString
{
    class RepForSub
    {
        public static string a = "abcd";
        public static string b = "cdabcdab";

        public static bool CanBe()
        {
            string newString = "";
            while(newString.Length <= b.Length)
            {
                newString += a;
            }
            Console.WriteLine(newString);
            int k = b.Length;
            string compare = "";

            for (int i = 0; i < k; i++)
            {
                compare += newString[i];
            }
            Console.WriteLine(compare);
            if (compare == b)
            {
                return true;
            }
            Console.WriteLine("");
            for(int i = k; i < newString.Length; i++)
            {
                string check = newString.Substring(i - k, b.Length);
                Console.WriteLine(check);
                if(check == b)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
