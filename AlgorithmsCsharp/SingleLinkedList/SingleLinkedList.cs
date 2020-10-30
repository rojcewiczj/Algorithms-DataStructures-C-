using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.SingleLinkedList
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void Display()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
        }
    }
}
