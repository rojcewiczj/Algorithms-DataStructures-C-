using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class BSTTree
    {
        public BSTNode root = null;


        public BSTTree() { }
        public void insert(int value)
        {
            BSTNode new_node = new BSTNode(value);

           

            if (root is null)
            {
    
                root = new_node;
            }
            else
            {
                BSTNode current = root;
                bool done = false;
                while (done is false) {
                    if (new_node.value < current.value)
                    {
                        if (current.left is null)
                        {
                            current.left = new_node;
                            done = true;
                        }
                        else
                        {
                            current = current.left;
                            
                        }
                    }
                    else if (new_node.value > current.value)
                    {
                        if (current.right is null)
                        {
                            current.right = new_node;
                            done = true;
                        }
                        else
                        {
                            current = current.right;

                        }
                    }

                }
            } }

        public void print_tree()
        {
            BSTNode current = root;
            Stack<BSTNode> stack = new Stack<BSTNode>();
            stack.Push(current);
            while (stack.Count > 0)
            {
                current = stack.Pop();
                Console.WriteLine("{0}", current.value);
              
                if (current.left != null)
                {
                   
                    stack.Push(current.left);
                }  if (current.right != null)
                {
                    stack.Push(current.right);
                }
                Console.WriteLine(" ");

            }
            

        }


    }

    
}
