using System.Linq;

namespace CodeWars._7Kyu
{
	public class ExesAndOhs
	{
		public static bool XO(string input)
		{
			var numberX = input.Count(i => "Xx".Contains(i));
			var numberO = input.Count(i => "Oo".Contains(i));
			return numberO == numberX;
		}
	}
}
