using System;

namespace CodeWars._8Kyu
{
	public class CenturyFromYearKata
	{
		public static int YearToCentury(int year)
		{
			return (int) Math.Ceiling(year / 100d);
		}
	}
}