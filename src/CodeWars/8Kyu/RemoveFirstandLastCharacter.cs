using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._8Kyu
{
	public class RemoveFirstandLastCharacter
	{
		public static string Remove_char(string s)
		{
			return s.Substring(1, s.Length - 2);
		}
	}
}
