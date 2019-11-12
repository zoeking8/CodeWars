using NUnit.Framework;
using System;
using CodeWars._8Kyu;

namespace CodeWars.UnitTests._8Kyu
{
	[TestFixture]
	public class LostWithoutAMapTests
	{
		[Test]
		public void MapTest()
		{
			Assert.AreEqual(new[] { 2, 4, 6 }, LostWithoutAMapKata.Maps(new[] { 1, 2, 3 }));
			Assert.AreEqual(new[] { 8, 2, 2, 2, 8 }, LostWithoutAMapKata.Maps(new[] { 4, 1, 1, 1, 4 }));
			Assert.AreEqual(new[] { 4, 4, 4, 4, 4, 4 }, LostWithoutAMapKata.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
		}
	}
}
