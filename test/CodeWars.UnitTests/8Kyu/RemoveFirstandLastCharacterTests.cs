using System;
using System.Collections.Generic;
using System.Text;
using CodeWars._8Kyu;
using NUnit.Framework;

namespace CodeWars.UnitTests._8Kyu
{
	[TestFixture]
	class RemoveFirstandLastCharacterTests
	{
		[Test]
		public void Test1()
		{
			StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstandLastCharacter.Remove_char("eloquent"));
			StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstandLastCharacter.Remove_char("country"));
			StringAssert.AreEqualIgnoringCase("erso", RemoveFirstandLastCharacter.Remove_char("person"));
			StringAssert.AreEqualIgnoringCase("lac", RemoveFirstandLastCharacter.Remove_char("place"));
			StringAssert.AreEqualIgnoringCase("", RemoveFirstandLastCharacter.Remove_char("ok"));
		}
	}
}
