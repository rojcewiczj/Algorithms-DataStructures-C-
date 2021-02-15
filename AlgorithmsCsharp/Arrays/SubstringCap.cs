using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace AlgorithmsCsharp.Arrays
{
    public class SubstringCap
    {
        public static string str = "aaBdblmnM";

        public static int Find()
        {
           
            int k = 2;
            string substring = "";
            bool worth_check = false;
            List<char> caps = new List<char>();
            for(int i = 0; i < k; i++)
            {
                substring += str[i];
                if (Char.IsUpper(str, i))
                {
                    caps.Add(str[i]);
                    worth_check = true;
                }
            }

            if (worthReturn(worth_check, caps, substring))
            {
                return substring.Length;
            }

            caps = new List<char>();
            worth_check = false;

            while(k <= str.Length)
            {
               
                for(int i = k; i < str.Length; i++)
                {
                    substring.Remove(0, 1);
                    substring += str[i];
                    if (Char.IsUpper(str, i))
                    {
                        caps.Add(str[i]);
                        worth_check = true;
                    }
                } 
                if (worthReturn(worth_check, caps, substring))
                    {
                        return substring.Length;
                    }

                caps = new List<char>();
                worth_check = false;
                k += 1;



            }

            return -1;



        }

        public static bool worthReturn(bool worth_check, List<char> caps, string substring)
        {  
            if (worth_check)
            {
                int count = caps.Count();
                foreach(char cap in caps)
                {
                    if (substring.Contains(Char.ToLower(cap)))
                    {
                        count -= 1;
                        if(count <= 1)
                        {
                            return true;
                        }
                    }
                   
                }

            }
            return false;


        }
    }
}
