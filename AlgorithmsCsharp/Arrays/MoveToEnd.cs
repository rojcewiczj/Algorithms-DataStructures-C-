using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class MoveToEnd
    {
		public static List<int> MoveElementToEnd(List<int> array, int toMove)
		{

			int i = 0;
			int j = array.Count - 1;
			bool swap = true;
			while (i < j)
			{
				swap = true;
				if (array[i] != toMove)
				{
					i += 1;
					swap = false;
				}
				if (array[j] == toMove)
				{
					j -= 1;
					swap = false;
				}
				if (swap == true)
				{
					int temp = array[j];
					array[j] = array[i];
					array[i] = temp;
				}

			}
			return array;
		}
	}
}
