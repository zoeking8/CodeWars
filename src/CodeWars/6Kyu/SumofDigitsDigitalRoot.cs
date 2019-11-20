using System;
using System.Linq;
using System.Numerics;

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
	public static class Kata
	{
		
	}
}
