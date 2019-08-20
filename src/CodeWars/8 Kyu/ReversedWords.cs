using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
	public class ReversedWords

	{
		public static string WordReverse(string str)
		{
			string[] words = str.Split(' ');
			Array.Reverse(words);
			return String.Join(" ", words);
		}
	}

}

