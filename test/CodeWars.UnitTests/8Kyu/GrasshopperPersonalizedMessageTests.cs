using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	class GrasshopperPersonalizedMessageTests
	{
		[TestFixture]
		public class SolutionTest
		{
			[Test]
			public void MyTest()
			{
				Assert.AreEqual("Hello boss", GrasshopperPersonalizedMessage.Greet("Daniel", "Daniel"));
				Assert.AreEqual("Hello guest", GrasshopperPersonalizedMessage.Greet("Greg", "Daniel"));
			}
		}
	}
}
