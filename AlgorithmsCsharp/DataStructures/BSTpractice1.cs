using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    public class BSTpractice1
    {
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
			if (this.value == value)
			{
				return true;
			}
			else
			{
				if (value < this.value)
				{
					if (left == null)
					{
						return false;
					}
					else
					{
						left.Contains(value);
					}
					if (value > this.value)
					{
						if (right == null)
						{
							return false;
						}
						else
						{
							right.Contains(value);
						}
					}
				}
			}

			return false;
		}

		public BST Remove(int value)
		{

		}
	}

}
}
