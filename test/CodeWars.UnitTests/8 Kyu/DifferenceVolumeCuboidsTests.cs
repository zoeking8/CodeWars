using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class DifferenceVolumeCuboidsTests
	{
		[TestCase(new[] {1, 4, 4}, new[] {3, 2, 5}, 14)]
		[TestCase(new[] {9, 7, 2}, new[] {5, 2, 2}, 106)]
		[TestCase(new[] {11, 2, 5}, new[] {1, 10, 8}, 30)]
		public void FindDifference(int[] a, int[] b, int expected)
		{
			var actual = DifferenceVolumeCuboidsKata.FindDifference(a, b);

			Assert.AreEqual(expected, actual);
		}
	}
}