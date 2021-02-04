using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class BSTcheck
    {
		public class Program
		{
			public static int FindClosestValueInBst(BST tree, int target)
			{
				// Write your code here.
				BST current = tree;
				int current_check = target - tree.value;
				int last_absolute = Math.Abs(current_check);
				int current_absolute = 0;
				int last_check = 0;
				while (last_absolute > current_absolute)
					last_check = current_check
				if (current_check == 0)
				{
					return current_check;
				}
				else
				{
					if (current_check > 0)
					{
						current = current.right;
					}
					else
					{
						current = current.left;
					}
				}
				current_check = target - current.value;
				current_absolute = Math.Abs(current_check)
		

		return -1;
			}

			public class BST
			{
				public int value;
				public BST left;
				public BST right;

				public BST(int value)
				{
					this.value = value;
				}
			}
		}

	}
}
