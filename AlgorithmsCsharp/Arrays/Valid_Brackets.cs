using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class Valid_Brackets
    {
        public static string str = "(())";

        public static bool check()
        {
            Stack<char> stack = new Stack<char>();
            List<char> rights = new List<char> { ')', ']', '}' };
            Dictionary<char, char> dicti = new Dictionary<char, char>();
            dicti['('] = ')';
            dicti['['] = ']';
            dicti['{'] = '}';

            for(int i = 0; i < str.Length; i++)
            {
                if (!rights.Contains(str[i])) { 
                stack.Push(str[i]);
                }
                else
                {
                    char last = stack.Pop();
                    Console.WriteLine(last);
                    if(dicti[last] != str[i])
                    {
                            return false;
                    }
                    
                }

            }

            if(stack.Count != 0)
            {
                return false;
            }
            return true;
            



        }

    }
}
