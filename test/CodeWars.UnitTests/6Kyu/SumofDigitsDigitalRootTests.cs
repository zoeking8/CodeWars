using CodeWars._6Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._6Kyu
{
	[TestFixture]

	class SumofDigitsDigitalRootTests
	{
		private SumofDigitsDigitalRoot num;

		[SetUp]
		public void SetUp()
		{
			num = new SumofDigitsDigitalRoot();
		}

		[TearDown]
		public void TearDown()
		{
			num = null;
		}

		[Test]
		public void Tests()
		{
			Assert.AreEqual(7, num.DigitalRoot(16));
			Assert.AreEqual(6, num.DigitalRoot(456));
		}
	}
}
