﻿using CodeWars._5kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._5Kyu
{
	[TestFixture]
	class MovingZerosToTheEndTests
	{
		[Test]
		public void Test()
		{
			Assert.AreEqual(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0},
				MovingZerosToTheEnd.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
		}
	}
}
