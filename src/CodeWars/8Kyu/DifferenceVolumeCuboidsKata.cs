using System;

namespace CodeWars._8Kyu
{
	public class DifferenceVolumeCuboidsKata
	{
		public static int FindDifference(int[] a, int[] b)
		{
			return Math.Abs(a[0] * a[1] * a[2] - b[0] * b[1] * b[2]);
		}
	}
}