using System.Linq;

namespace CodeWars._6Kyu
{
	public class PersistentBugger
	{
		public static int Persistence(long n)
		{
			var loopCounter = 0;
			while (n > 9)
			{
				n = (n % 10) * (n / 10);
				loopCounter++;
				if (n < 10)
				{
					break;
				}
			}
			return loopCounter;
		}
	}
}
