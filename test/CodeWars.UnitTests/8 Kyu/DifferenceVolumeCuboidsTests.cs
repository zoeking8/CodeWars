using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class DifferenceVolumeCuboidsTests
	{
		[TestCase(new int[] { 1, 4, 4 }, new int[] { 3, 2, 5 }, 14)]
		[TestCase(new int[] { 9, 7, 2 }, new int[] { 5, 2, 2 }, 106)]
		[TestCase(new int[] { 11, 2, 5 }, new int[] { 1, 10, 8 }, 30)]


		public void FindDifference(int[] a, int[] b, int expected)
		{
			var actual = DifferenceVolumeCuboids.FindDifference(a, b);

			Assert.AreEqual(expected, actual);
		}
	}
}
