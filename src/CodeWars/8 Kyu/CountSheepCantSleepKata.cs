using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
	public class CountSheepCantSleepKata
	{
		public static string CountSheep(int n)
		{
			var sheepCount = new StringBuilder();

			for (int i = 1; i <= n; i++)
			{
				sheepCount.Append(i.ToString() + " sheep...");

			}

			return sheepCount.ToString();

		} 
	}
}
