using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class DalmatiansTests
	{
		[TestCase(26, "More than a handful!")]
		[TestCase(8, "Hardly any")]
		[TestCase(14, "More than a handful!")]
		[TestCase(101, "101 DALMATIONS!!!")]
		[TestCase(100, "Woah that's a lot of dogs!")]
		[TestCase(102, "Woah that's a lot of dogs!")]
		public void CountSheep(int n, string expected)
		{
			var actual = DalmatiansKata.HowManyDalmatians(n);
			Assert.AreEqual(expected, actual);
		}
	}
}