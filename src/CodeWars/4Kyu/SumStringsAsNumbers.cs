using System.Numerics;

namespace CodeWars._4Kyu
{
	public class SumStringsAsNumbers
	{
		public static string sumStrings(string a, string b)
		{
			BigInteger numberA;
			BigInteger numberB;

			var aBool = BigInteger.TryParse(a, out numberA);
			var bBool = BigInteger.TryParse(b, out numberB);

			if (aBool == true && bBool == true)
			{
				var result = numberA + numberB;
				return result.ToString();
			}
			else if (aBool == true)
			{
				return numberA.ToString();
			}
			else if (bBool == true)
			{
				return numberB.ToString();
			}
			else
			{
				return null;
			}
		}
	}
}
