using System;

namespace CodeWars._8Kyu
{
	public class CenturyFromYearKata
	{
		public static double YearToCentury(double year)
		{
			return (double) Math.Ceiling(year / 100);
		}
	}
}