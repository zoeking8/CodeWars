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
				n = n.ToString().ToArray().Aggregate(1, (runningProduct, nextFactor) => runningProduct * nextFactor);
				loopCounter++;
			}
			return loopCounter;
		}
		
	}
}
