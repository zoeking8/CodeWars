using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class ReversedWordsTests
	{
		[TestCase("world! hello", "hello world!")]
		[TestCase("this like speak doesn't yoda", "yoda doesn't speak like this")]
		[TestCase("foobar", "foobar")]
		[TestCase("boat your row row row", "row row row your boat")]
		public void WordReverse(string str, string expected)
		{
			var actual = ReversedWordsKata.WordReverse(str);
			Assert.AreEqual(expected, actual);
		}
	}
}