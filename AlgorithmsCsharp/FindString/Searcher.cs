using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.FindString
{
    class Searcher
    {

        public string _Long;

        public string _Short;

        public Searcher(string Long, string Short)
        {
            _Long = Long;
            _Short = Short;
        }


        public int Find()
        {
            int count = 0;
            int i = 0;
            int j = 0;

            while (i < _Long.Length)
            {

                
                while(j < _Short.Length)
                {
                    if (_Short[j] != _Long[i + j])
                    {
                        break;
                    }
                    if (j == _Short.Length - 1)
                    {
                        count += 1;
                        Console.WriteLine(" {0} ", count);
                    }
                   Console.WriteLine(_Short[j]);
                   j++;
                }
                j = 0;
                i++;
            }


            return count;
        }
    }
}
