namespace CodeWars._6Kyu
{
	public class Dubstep
	{
		public static string SongDecoder(string input)
		{
			return input.Replace("WUB", " ").Replace("   ", " ").Replace("  ", " ").Trim();
		}
	}
}
