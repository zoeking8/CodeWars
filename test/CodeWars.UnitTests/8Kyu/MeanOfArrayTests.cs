using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	public class MeanOfArrayTests
	{
		[TestCase(new[] {2, 2, 2, 2}, 2)]
		[TestCase(new[] {5, 10}, 7)]
		public void GetAverage(int[] marks, int expected)
		{
			var actual = MeanOfArrayKata.GetAverage(marks);

			Assert.AreEqual(expected, actual);
		}
	}
}