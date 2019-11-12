using System;
using System.Linq;

namespace CodeWars._7Kyu
{
	public class FormTheMinimumKata
	{
		public static long MinValue(int[] a)
		{
			Array.Sort(a);
			a = a.Distinct().ToArray();
			return long.Parse(string.Join("", a));
		}
	}
}
