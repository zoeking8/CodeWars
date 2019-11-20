using CodeWars._7Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._7Kyu
{
	[TestFixture]
	class ExesAndOhsTests
	{
		[Test]
		public void ExampleTests()
		{
			Assert.AreEqual(true, ExesAndOhs.XO("xo"));
			Assert.AreEqual(true, ExesAndOhs.XO("xxOo"));
			Assert.AreEqual(false, ExesAndOhs.XO("xxxm"));
			Assert.AreEqual(false, ExesAndOhs.XO("Oo"));
			Assert.AreEqual(false, ExesAndOhs.XO("ooom"));
		}
	}
}
