using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CodeWars._8Kyu
{
	public class FindTheSmallestIntegerInTheArray
	{
		public static int FindSmallestInt(int[] args)
		{
			return args.OrderByDescending(x => x).LastOrDefault();
		}
	}
	
}
