using System.Collections.Generic;

namespace CodeWars._5kyu
{
	public class MovingZerosToTheEnd
	{
		public static int[] MoveZeroes(int[] arr)
		{
			List<int> numberList = new List<int>();
			List<int> zeroList = new List<int>();

			foreach (var number in arr)
			{
				if (number != 0)
				{
					 numberList.Add(number);
				}
				else
				{
					zeroList.Add(number);
				}
			}

			numberList.AddRange(zeroList);

			return numberList.ToArray();
		}
	}
}