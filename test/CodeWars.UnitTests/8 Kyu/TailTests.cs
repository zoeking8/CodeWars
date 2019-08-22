using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class TailTests
	{
		[TestCase("Fox", "x", true)]
		[TestCase("Rhino", "o", true)]
		[TestCase("Meerkat", "t", true)]
		[TestCase("Emu", "t", false)]
		public void CorrectTail(string body, string tail, bool expected)
		{
			var actual = TailKata.CorrectTail(body, tail);
			Assert.AreEqual(expected, actual);
		}
	}
}