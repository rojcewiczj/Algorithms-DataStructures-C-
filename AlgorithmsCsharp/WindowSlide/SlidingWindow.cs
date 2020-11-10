using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.WindowSlide
{
    class SlidingWindow
    {
        private int[] arr;
        private int k;
        public SlidingWindow(int[] array, int size)
        {
            arr = array;
            k = size;
        }


        public int returnLargest()
        {
            int largest = 0;
            int total = 0;
            int n = arr.Length;
            Console.WriteLine("{0}", n);
            int i = k;

            for (int j = 0; j < k; j++)
            {
                total += arr[j];
                Console.WriteLine("{0}", total);

            }

            while (i < n)
            {
                if (total > largest)
                {
                    largest = total;
                }
                total = (total - arr[i - k]) + arr[i];

                i += 1;
                Console.WriteLine("{0}", total);
            }




            return largest;
        }
    }


}
