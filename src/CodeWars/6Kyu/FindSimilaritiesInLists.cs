using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars._6Kyu
{
	class FindSimilaritiesInLists
	{
		public static bool SimilarityTwoLists(IEnumerable<string> listA, IEnumerable<string> listB)
		{
			return listA.Any(x => listB.Contains(x));
		}
	}
}
