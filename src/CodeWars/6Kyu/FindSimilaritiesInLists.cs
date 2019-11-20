using System.Collections.Generic;
using System.Linq;


namespace CodeWars._6Kyu
{
	public class FindSimilaritiesInLists
	{
		public static string AnySimilarity(List<int> firstList, List<int> secondList, int n)
		{
			var similarities = firstList.Where(x => secondList.Contains(n)).ToList();
			return similarities.ToString();
		}
	}
}