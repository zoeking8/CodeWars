using System.Linq;

namespace CodeWars._6Kyu
{
	public class SumofDigitsDigitalRoot
	{
		public int DigitalRoot(long n)
		{
			while (n > 9)
			{
				n = n.ToString().ToCharArray().Sum(x => x - '0');
			}
			return (int)n;
		}
	}
}
