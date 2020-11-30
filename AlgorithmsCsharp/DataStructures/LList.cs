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
            
            if(length == 0)
            {
                Head = null;
                Tail = null;
            }
            return current_tail;
        }

    }


   
}
