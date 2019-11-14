using CodeWars._6Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._6Kyu
{
	class Multiplesof3or5Tests
	{
		[TestFixture]
		public class Tests
		{
			[Test]
			public void Test()
			{
				Assert.AreEqual(23, Multiplesof3or5.Solution(10));
			}
		}
	}
}
