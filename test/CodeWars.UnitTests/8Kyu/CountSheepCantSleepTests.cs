using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	public class CountSheepCantSleepTests
	{
		[TestCase(1, "1 sheep...")]
		[TestCase(2, "1 sheep...2 sheep...")]
		[TestCase(3, "1 sheep...2 sheep...3 sheep...")]
		public void CountSheep(int n, string expected)
		{
			var actual = CountSheepCantSleepKata.CountSheep(n);
			Assert.AreEqual(expected, actual);
		}
	}
}