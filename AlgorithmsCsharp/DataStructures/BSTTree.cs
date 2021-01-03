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
            bool inserted = false;
            BSTNode new_node = new BSTNode(value);
            if (root == null)
            {
                root = new_node;
            }
            else
            {     
               BSTNode current = root;
               while(inserted == false) {
                  
                    if(value < current.value)
                    {
                        if (current.left == null)
                        {
                            current.left = new_node;
                            inserted = true;
                        }
                        else
                        {
                            current = current.left;
                        }
                   
                    
                    }
                    else if(value > current.value)
                    {
                        if (current.right == null)
                        {
                            current.right = new_node;
                            inserted = true;
                        }
                        else
                        {
                            current = current.right;
                        }
                    
                    } 
                }
            }
        
        
        
        }

        public void print_tree()
        {   
         
            Stack<BSTNode> stack = new Stack<BSTNode>();
            stack.Push(root);
            Stack<string> direct = new Stack<string>();
            direct.Push("root");
            while(stack.Count > 0)
            {
                BSTNode current = stack.Pop();
                string direction = direct.Pop();

                Console.WriteLine("{0} : {1}", direction, current.value);

                if (current.right != null) 
                {

                    stack.Push(current.right);
                    direct.Push("right");
                }

                if (current.left != null)
                {

                    stack.Push(current.left);
                    direct.Push("left");
                

                }

                
            }

            

        }


    }

    
}
