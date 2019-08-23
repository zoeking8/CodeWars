using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	public class TriangleAnglesTests
	{
		[TestCase(30, 60, 90)]
		[TestCase(60, 60, 60)]
		[TestCase(43, 78, 59)]
		public void OtherAngle(int a, int b, int expected)
		{
			var actual = TriangleAnglesKata.OtherAngle(a, b);
			Assert.AreEqual(expected, actual);
		}
	}
}