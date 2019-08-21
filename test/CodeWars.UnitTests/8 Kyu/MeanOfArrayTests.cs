using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class MeanOfArrayTests
	{
		[TestCase(new int[] { 2, 2, 2, 2}, 2)]
		[TestCase(new int[] { 5, 10 }, 7)]

		public void GetAverage(int[] marks, int expected)
		{
			var actual = MeanOfArrayKata.GetAverage(marks);

			Assert.AreEqual(expected, actual);
		}
	}
}
