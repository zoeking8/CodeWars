using System;

namespace CodeWars._7Kyu
{
	public class MaximumProductKata
	{
		public static int AdjacentElementsProduct(int[] array)
		{
			int product = array[0] * array[1];
			for (int i = 1; i < array.Length - 1; i++)
				product = Math.Max(product, array[i] * array[i + 1]);
			return product;
		}
	}
}
