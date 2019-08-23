using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	public class OnlyNeedOneTests
	{
		[TestCase(new object[] {66, 199}, 66, true)]
		[TestCase(new object[] {12, 19, 299}, 66, false)]
		[TestCase(new object[] {'t', 'e', 's', 't'}, 'e', true)]
		[TestCase(new object[] {"what", "a", "great", "kata"}, "kat", false)]
		public void Check(object[] a, object X, bool expected)
		{
			var actual = OnlyNeedOneKata.Check(a, X);
			Assert.AreEqual(expected, actual);
		}
	}
}