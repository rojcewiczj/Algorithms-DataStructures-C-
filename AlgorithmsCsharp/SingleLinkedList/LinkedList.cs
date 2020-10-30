using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AlgorithmsCsharp.SingleLinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void addToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.addToEnd(data);
            }
        }
        public void Print()
        {
            Console.Write("|| {0} || -->", data);

            if (next != null)
            {
                next.Print();
            }
        }

        public void addSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
        }
    }

    public class LinkedList
    {
        public Node headNode;


        public LinkedList()
        {
            headNode = null;
        }

        public void addToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.addToEnd(data);
            }
        }

        public void addToTheBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }
        public void addSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                addToTheBeginning(data);
            }
            else
            {
                headNode.addSorted(data);
            }
        }
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
            
        }


    }




}
