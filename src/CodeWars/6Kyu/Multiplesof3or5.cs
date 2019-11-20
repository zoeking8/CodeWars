using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6Kyu
{
	public class Multiplesof3or5
	{
		public static int Solution(int value)
		{
			List<int> numbersInts = new List<int>();
			for (int i = 0; i < value; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					numbersInts.Add(i);
				}
			}
			var sum = numbersInts.Sum();
			return sum;
		}
	}
}
