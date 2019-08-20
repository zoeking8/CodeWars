using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class StringToArrayTests
	{
		[TestCase("Robin Singh", new object[] { "Robin", "Singh" })]
		[TestCase("I love arrays they are my favorite", new object[] { "I", "love", "arrays", "they", "are", "my", "favorite" })]

		public void StrToArr(string str, object expected)
		{
			var actual = StringToArray.StrToArr(str);
			Assert.AreEqual(expected, actual);
		}
	}
}