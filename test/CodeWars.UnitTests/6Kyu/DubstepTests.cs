using CodeWars._6Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._6Kyu
{
	class DubstepTests
	{
		[Test]
		public void Test1()
		{
			Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
		}

		[Test]
		public void Test2()
		{
			Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
		}
	}
}
