﻿using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	public class StringToArrayTests
	{
		[TestCase("Robin Singh", new object[] {"Robin", "Singh"})]
		[TestCase("I love arrays they are my favorite",
			new object[] {"I", "love", "arrays", "they", "are", "my", "favorite"})]
		public void StrToArr(string str, object expected)
		{
			var actual = StringToArrayKata.StrToArr(str);
			Assert.AreEqual(expected, actual);
		}
	}
}