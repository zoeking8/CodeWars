using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class OppositeNumberTests
	{
		[TestCase(3, -3)]
		[TestCase(2, -2)]
		[TestCase(5, -5)]
		[TestCase(-14, 14)]
		[TestCase(-34, 34)]
		public void Opposite(int n, int expected)
		{
			var actual = OppositeNumberKata.Opposite(n);
			Assert.AreEqual(expected, actual);
		}
	}
}