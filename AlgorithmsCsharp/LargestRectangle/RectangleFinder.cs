using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsCsharp.LargestRectangle
{
    class RectangleFinder
    {
        public int[] _arr;

        public RectangleFinder(int[] arr)
        {
            _arr = arr;
        }

        public int Find()
        {
            List<int> sizes = new List<int>();
            Stack<int> stack = new Stack<int>();

            int i = 0;

            while (i < _arr.Length)
            {
                if (stack.Count == 0 ||_arr[stack.Peek()] < _arr[i])
                {
                    stack.Push(i);


                }
                else if (_arr[stack.Peek()] > _arr[i])
                {
                    while (stack.Count != 0 && _arr[stack.Peek()] > _arr[i])
                    {
                        int index = stack.Pop();
                        int height = _arr[index];
                        int width = i - index;
                        int size = height * width;
                        sizes.Add(size);
                    }

                }
                i++;






            }
            return sizes.Max();


        }
    }
}
