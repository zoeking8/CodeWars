using System;

namespace CodeWars._8Kyu
{
	public class ReversedWordsKata

	{
		public static string WordReverse(string str)
		{
			var words = str.Split(' ');
			Array.Reverse(words);
			return string.Join(" ", words);
		}
	}
}