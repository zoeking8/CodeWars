using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
	public class CenturyFromYear
	{
		public static int YearToCentury(int year)
		{
			return (int)Math.Ceiling(year / 100d);
		}
	}

}
