using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class IsStringUppercaseTests
	{
		[TestCase("c", false)]
		[TestCase("C", true)]
		[TestCase("ACSKLDFJSgSKLDFJSKLDFJ", false)]
		[TestCase("ACSKLDFJSGSKLDFJSKLDFJ", true)]

		public void Uppercase(string s, bool expected)
		{
			var actual = IsStringUppercaseKata.Uppercase(s);
			Assert.AreEqual(expected, actual);
		}
	}
}