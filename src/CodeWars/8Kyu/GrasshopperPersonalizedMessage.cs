namespace CodeWars._8Kyu
{
	public class GrasshopperPersonalizedMessage
	{
		public static string Greet(string name, string owner)
		{
			if (name == owner)
			{
				return "Hello boss";

			}
			else
			{
				return "Hello guest";
			}
		}
	}
}
