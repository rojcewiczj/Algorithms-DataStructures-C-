using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    public class BSTpractice
    {
		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}

			public BST Insert(int value)
			{
				if (value < this.value)
				{
					if (left == null)
					{
						left = new BST(value);
					}
					else
					{
						left.insert(value);
					}
				}
				else
				{
					if (right == null)
					{
						right = new BST(value);
					}
					else
					{
						right.insert(value);
					}
				}
				return this;
			}

			public bool Contains(int value)
			{

				return false;
			}

			public BST Remove(int value)
			{

				return this;
			}
		}
	}
}
