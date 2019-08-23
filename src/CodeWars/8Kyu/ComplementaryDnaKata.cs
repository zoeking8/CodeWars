using System.Collections.Generic;
using System.Linq;

namespace CodeWars._8Kyu
{
	public class ComplementaryDnaKata
	{
		public static Dictionary<char, string> _lookup;

		static ComplementaryDnaKata()
		{
			_lookup = new Dictionary<char, string>
			{
				{'A', "T"},
				{'T', "A"},
				{'C', "G"},
				{'G', "C"}
			};
		}
		public static string MakeComplement(string dna)
		{
			return string.Concat(dna.Select(x => _lookup[x]));
		}
	}
}