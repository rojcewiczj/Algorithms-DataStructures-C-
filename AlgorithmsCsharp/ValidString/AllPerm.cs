using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.ValidString
{
    class AllPerm
    {
        public static string str = "abc";

        public static List<string> perms = new List<string> { };

        public static void find()
        {

            string new_string = "";

            for (int i = 0; i < str.Length; i++)
            {
                char core = str[i];

                new_string += core;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] != core)
                    {
                        new_string += str[j];
                    }

                }

                perms.Add(new_string);
                new_string = "";
                new_string += core;
                for (int j = str.Length - 1; j > -1; j--)
                {
                    if (str[j] != core)
                    {
                        new_string += str[j];
                    }

                }

                perms.Add(new_string);
                new_string = "";
                

            }
           
            foreach (string perm in perms)
            {
                Console.WriteLine(perm);
            }






        }
    }
}
