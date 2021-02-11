using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class ProductArray
    {
		public int[] ArrayOfProducts(int[] array)
		{
			int[] product_array = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{

				int product = 1;
				for (int j = 0; j < array.Length; j++)
				{
					if (j != i)
					{
						product *= array[j];
					}
				}
				product_array[i] = product;
			}
			return product_array;
		}
	}
}
