using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars._6Kyu
{
	public class FindSimilaritiesInLists
	{
		public static string AnySimilarity(List<int> firstList, List<int> secondList, int n)
		{
			var similarities = firstList.Where(x => secondList.Contains(n));
			return similarities.ToString();
		}
	}
}
