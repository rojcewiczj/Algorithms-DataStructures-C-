using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.DataStructures
{
    class Palidrome
    {
		public static bool IsPalindrome(string str)
		{
			string new_string = string.Empty;
			for (int i = str.Length - 1; i > -1; i--)
			{
				new_string += str[i];
			}
			if (str == new_string)
			{
				return true;
			}
			return false;
		}
	}
}
