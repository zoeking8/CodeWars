using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
	public static class ReversedStrings
	{
		public static string StringReverse(string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}
