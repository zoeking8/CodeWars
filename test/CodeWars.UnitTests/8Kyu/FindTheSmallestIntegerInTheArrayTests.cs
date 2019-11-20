using System;
using System.Collections.Generic;
using System.Text;
using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	[TestFixture]
	class FindTheSmallestIntegerInTheArrayTests
	{
		[Test]
		[TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
		[TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
		public static int FixedTest(int[] args)
		{
			return FindTheSmallestIntegerInTheArray.FindSmallestInt(args);
		}
	}
}
