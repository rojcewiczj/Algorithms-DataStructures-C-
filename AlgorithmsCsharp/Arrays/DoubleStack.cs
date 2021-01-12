using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    
    class DoubleStack
    {
        public static List<string> requests = new List<string> { "push 1", "push 2", "pop", "push 3", "pop" };


        public static List<int> Find()
        {
            List<int> to_return = new List<int>();
            Queue<int> queue = new Queue<int>();


            foreach(string request in requests)
            {
                if(request[1] == 'u')
                {
                    queue.Enqueue((int)(request[5] -'0'));
                }
                else
                {
                    to_return.Add(queue.Dequeue());
                }
            }

            return to_return;




        }


    }
}
