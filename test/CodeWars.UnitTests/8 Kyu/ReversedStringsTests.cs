using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class ReversedStringsTests
	{
		[TestCase("dlrow", "world")]
		[TestCase("world", "dlrow")]
		[TestCase("abc", "cba")]
		public void StringReverse(string str, string expected)
		{
			var actual = ReversedStringsKata.StringReverse(str);
			Assert.AreEqual(expected, actual);
		}
	}
}