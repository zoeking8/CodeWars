using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class CenturyFromYearTests
	{
		[TestCase(1705, 18)]
		[TestCase(1900, 19)]
		[TestCase(1601, 17)]
		[TestCase(2000, 20)]
		public void YearToCentury(int year, int expected)
		{
			var actual = CenturyFromYearKata.YearToCentury(year);

			Assert.AreEqual(expected, actual);
		}
	}
}