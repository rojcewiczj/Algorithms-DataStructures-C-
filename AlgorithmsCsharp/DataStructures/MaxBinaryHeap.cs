using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class MaxBinaryHeap
    {
        public List<int> list = new List<int>();


        public void bubbleUp()
        {
            int index = list.Count - 1;
            int element = list[index];
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                int parent = list[parentIndex];
                if (element > parent)
                {
                    list[parentIndex] = element;
                    list[index] = parent;
                    index = parentIndex;
                }
                else
                {
                    break;
                }

            }
        }

        public void bubbleDown()
        {
            int index = 0;
            int length = list.Count;
            int element = list[index];
            while (true)
            {
                int left_child_index = (2 * index) + 1;
                int right_child_index = (2 * index) + 2;
                int left_child = 0;
                int right_child = 0;
                int swap = 0;
                if (left_child_index < length)
                {
                    left_child = list[left_child_index];
                    if (left_child > element)
                    {
                        swap = left_child_index;
                    }
                }
                if (right_child_index < length)
                {
                    right_child = list[right_child_index];
                    if (right_child > element)
                    {

                        if (right_child > left_child || left_child == 0)
                        {
                            swap = right_child_index;
                        }
                    }
                }
                if (swap == 0)
                {
                    break;
                }
                else
                {
                    list[index] = list[swap];
                    index = swap;
                }
            }


        }
        public void insert(int value)
        {
            list.Add(value);

            bubbleUp();

        }

        public void print()
        {
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }


        public int extractMax()
        {
            int max = list[0];
            if (list.Count > 1)
            {
                int current_max = list[0];
                int current_last = list[list.Count - 1];
                list[0] = current_last;
                list[list.Count - 1] = current_max;
                list.RemoveAt(list.Count - 1);
                bubbleDown();
            }
            else
            {
                list.RemoveAt(0);
            }
            return max;
        }
    }
}
