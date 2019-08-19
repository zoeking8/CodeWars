using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class ConvertNumberStringTests
	{
		[TestCase(123, "123")]
		[TestCase(999, "999")]
		[TestCase(4788, "4788")]

		public void MakeComplement(int num, string expected)
		{
			var actual = ConvertNumberString.NumberToString(num);

			Assert.AreEqual(expected, actual);
		}
	}

}