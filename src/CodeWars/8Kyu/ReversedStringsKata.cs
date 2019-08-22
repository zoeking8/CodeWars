using System;

namespace CodeWars._8Kyu
{
	public static class ReversedStringsKata
	{
		public static string StringReverse(string str)
		{
			var charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}