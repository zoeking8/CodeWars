using System.Linq;

namespace CodeWars._5kyu
{
	public class Scramblies
	{
		public static bool Scramble(string str1, string str2)
		{
			var commonLetters= str1.Intersect(str2);
			var commonCount = 0;
			foreach (var letter in commonLetters)
			{
				commonCount++;
			}

			if (commonCount == str2.Length)
			{
				return true;
			}
			return false;
		}
	}
}
