using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AlgorithmsCsharp.SingleLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert in empty list/Insert in beginning of the list");
                Console.WriteLine("5. Insert a node at the end of the list");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        list.Display();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.Write("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.search(data);
                
                }

            }
        }
    }
}
