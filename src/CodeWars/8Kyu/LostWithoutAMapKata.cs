namespace CodeWars._8Kyu
{
	public class LostWithoutAMapKata
	{
		public static int[] Maps(int[] x)
		{
			for (var i = x.Length - 1; i >= 0; i--)
			{
				x[i] += x[i];
			}
			return x;
		}
	}
}