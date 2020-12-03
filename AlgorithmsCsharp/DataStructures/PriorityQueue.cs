using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class PriorityQueue
    {
        public List<PQNode> list = new List<PQNode>();


        public void Insert(PQNode element)
        {
            list.Add(element);
            if (list.Count > 1)
            {
                BubbleUp();
            }

        }

        public void Remove()
        {
            if (list.Count > 1)
            {
                PQNode last = list[list.Count - 1];
                list[0] = last;
                list.RemoveAt(list.Count - 1);
                SinkDown();
            }
            else
            {
                list.RemoveAt(0);
            }
        }

        public void BubbleUp()
        {
           
            int index = list.Count - 1;
            PQNode element = list[index];
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                PQNode parent = list[parentIndex];
               Console.WriteLine(parentIndex);
                if (element.priority <= parent.priority)
                {
                    break;
                }
                else
                {
                    
                    list[parentIndex] = element;
                    list[index] = parent;
                    index = parentIndex;
                }
            }
        }

        public void SinkDown()
        {
            int index = 0;
            int length = list.Count;
            PQNode element = list[0];

            while (true)
            {
                int leftChildIndex = (2 * index) + 1;
                int rightChildIndex = (2 * index) + 2;
                PQNode leftChild = new PQNode(string.Empty, 0);
                PQNode rightChild = new PQNode(string.Empty, 0);
                int swap = 0;
                if (leftChildIndex < length)
                {
                    leftChild = list[leftChildIndex];
                    if (leftChild.priority > element.priority)
                    {
                        swap = leftChildIndex;
                    }
                }
                if (rightChildIndex < length)
                {
                    rightChild = list[rightChildIndex];
                    if (swap == 0 && rightChild.priority > element.priority || swap != 0 && rightChild.priority > leftChild.priority)
                    {
                        swap = rightChildIndex;
                    }
                }
                if (swap == 0)
                {
                    break;
                }
                else
                {
                    list[index] = list[swap];
                    list[swap] = element;
                    index = swap;
                }
            }
        }

        public void print()
        {
            foreach(PQNode element in list)
            {
                Console.WriteLine(" {0} : {1} ", element.value, element.priority);
            }
        }
    }
}
