using System;

namespace CodeWars
{
	public class ReversedWordsKata

	{
		public static string WordReverse(string str)
		{
			string[] words = str.Split(' ');
			Array.Reverse(words);
			return String.Join(" ", words);
		}
	}

}

