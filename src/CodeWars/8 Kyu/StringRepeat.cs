using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
	public class StringRepeat
	{
		public static string RepeatStr(int n, string s)
		{

			var output = new StringBuilder();

			for (int i = 0; i < n; i++)
			{
				output.Append(s);
			}

			return output.ToString();

		}
	}
}
