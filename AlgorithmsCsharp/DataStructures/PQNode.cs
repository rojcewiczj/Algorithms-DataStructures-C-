using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class PQNode
    {
        public string value;
        public int priority;


        public PQNode(string _value, int _priority)
        {
            value = _value;
            priority = _priority;
        }
    }
}
