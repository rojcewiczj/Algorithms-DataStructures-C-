using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class LList
    {
        public LLNode Head;

        public LLNode Tail;

        public int length = 0;

        public int pattern_check = 0;

        public LList()
        {
            Head = null;
            Tail = null;
            
        }


        public void push(int value)
        {
            LLNode new_node = new LLNode(value);

            if (Head is null)
            {
                Head = new_node;
                Tail = new_node;
            }
            else
            {
                LLNode Old_tail = Tail;
                Tail.next = new_node;
                Tail = new_node;
                Tail.previous = Old_tail;
            }
            length++;

        }

        public LLNode Pop()
        {


            LLNode current = Head;
            while (current != null)
            {
                current = current.next;
            }
            LLNode current_tail = current;
            LLNode new_tail = current.previous;
            Tail = new_tail;
            Tail.next = null;

            length--;

            if (length == 0)
            {
                Head = null;
                Tail = null;
            }
            return current_tail;
        }

        public void patternMarker()
        {

            LLNode current = Head;
            List<int> list = new List<int>();
            while (current.next != null)
            {
                if (list.Count == 0)
                {
                    list.Add(current.value);
                }
                else if (current.value != list[0])
                {
                    list.Add(current.value);
                }
                else
                {
                    list.RemoveAt(0);

                }
                if (list.Count == 0)
                {
                    pattern_check = current.value;
                }

                current = current.next;

            }
        }
        public void print()
        {

            LLNode current = Head;
            List<int> list = new List<int>();
            while(current.next != null)
            {

                if (current.value == pattern_check)
                {
                    Console.WriteLine("{0} end of cycle", current.value);
                }
                else {
                Console.WriteLine(current.value); 
                }
                current = current.next;
                
            }


        }

    }


   
}
