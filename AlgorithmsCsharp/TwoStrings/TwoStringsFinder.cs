using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.TwoStrings
{
    class TwoStringsFinder
    {
        public string _one;
        public string _two;

        public TwoStringsFinder(string one, string two)
        {
            _one = one;
            _two = two;
           
        }
        public bool Find()
        {
            bool found = false;

            foreach (var letter in _one)
            {

                if (_two.Contains(letter))
                {
                    found = true;

                }

            }
            return found;

        }
    }
}
