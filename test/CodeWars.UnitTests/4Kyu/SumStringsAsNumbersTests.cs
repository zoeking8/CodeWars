using CodeWars._4Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._4Kyu
{
	class SumStringsAsNumbersTests
	{
		[Test]
		public void Given123And456Returns579()
		{
			Assert.AreEqual("579", SumStringsAsNumbers.sumStrings("123", "456"));
		}
	}
}
