using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManagement
{
	public static class StringEvaluator
	{

		public static bool IsPalindrome(string stringValue)
		{

			for (int i = 0; i < stringValue.Length; i++)
			{
				// w/an odd numbered palindrome: check if its the middle character
				// > and continue as to not compare to any other character in the 
				// > string.
				if (stringValue.Length % 2 > 0
					&&
				   i == (stringValue.Length / 2 + 1))
				{
					continue;
				}
				else
				{
					if (stringValue[i] != stringValue[(stringValue.Length -1) - i])
                    {
						return false;
                    }
                    else
                    {
						continue;
                    }
				}
			}
			return true;
		}

	}
}
