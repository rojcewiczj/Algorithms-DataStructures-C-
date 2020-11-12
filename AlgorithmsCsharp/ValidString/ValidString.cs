using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.ValidString
{
    class ValidString
    {
        private string str;

        public ValidString(string _str)
        {
            str = _str;
        }

        public string returnValid()
        {
        
            Dictionary<char, int> dicti = new Dictionary<char, int>();
            Dictionary<int, int> sec_dicti = new Dictionary<int, int>();
            int differences = 0;
            bool tooMany = false;
            foreach (char letter in str)
            {
                if (!dicti.ContainsKey(letter))
                {
                    dicti[letter] = 1;
                }
                else
                {
                    dicti[letter] += 1;
                }
                if (!sec_dicti.ContainsKey(dicti[letter]))
                {
                    sec_dicti[dicti[letter]] = 1;
                }
                else
                {
                    if (sec_dicti.ContainsKey(dicti[letter] - 1))
                    { 
                        sec_dicti[dicti[letter] - 1] -= 1;
                        if (sec_dicti[dicti[letter]-1] == 1)
                        {
                            Console.WriteLine(" {0} ", sec_dicti[dicti[letter] - 1]);
                            sec_dicti.Remove(dicti[letter] - 1);
                        }


                    }

                    sec_dicti[dicti[letter]] += 1;
                }
                Console.WriteLine("  {0} : {1} --- {2} : {3}  ", letter, dicti[letter], dicti[letter], sec_dicti[dicti[letter]]);
            }
            int lastKey = 0;
          
            foreach(KeyValuePair<int,int> entry in sec_dicti)
            {
                Console.WriteLine(" {0} -- {1}  ", entry.Key, entry.Value);
                if (lastKey == 0)
                {
                    
                    lastKey = entry.Key;

                }
                else
                {
                    if (entry.Key > lastKey || entry.Key < lastKey)
                    {
                        int lesser;
                        if (sec_dicti[entry.Key] < sec_dicti[lastKey])
                        {
                            lesser = entry.Key;
                        }
                        else
                        {
                            lesser = lastKey;
                        }
                        differences += sec_dicti[lesser];
                       
                       
                    }
                    else if (entry.Key - 1 > lastKey || entry.Key + 1 < lastKey)
                    {
                        tooMany = true;
                        
                    }
                    lastKey = entry.Key;
                };
            }

            if (differences > 1)
            {
                tooMany = true;
            }

            if(tooMany == true)
            {
                 return "NO";
            }
            else
            {
                return "YES";
            }
            


        }
    }
}
