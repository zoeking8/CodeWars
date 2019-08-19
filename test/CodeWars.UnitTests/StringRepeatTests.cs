﻿using NUnit.Framework;

namespace CodeWars.UnitTests
{
	public class StringRepeatTests
	{
		[TestCase(3, "*", "***")]
		[TestCase(2, "I", "II")]
		[TestCase(5, "Hello", "HelloHelloHelloHelloHello")]

		public void RepeatStr(int n, string s, string expected)
		{
			var actual = StringRepeat.RepeatStr(n, s);
			Assert.AreEqual(expected, actual);
		}
	}
}