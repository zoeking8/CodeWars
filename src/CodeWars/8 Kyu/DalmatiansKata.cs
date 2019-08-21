using System;
using System;
using System.Collections.Generic;
using System.Linq;
public static class DalmatiansKata
{
	public static string HowManyDalmatians(int n)
	{
		if (n <= 10)
			return "Hardly any";

		if (n <= 50)
			return "More than a handful!";

		if (n == 101)
			return "101 DALMATIONS!!!";

		return "Woah that's a lot of dogs!";

	}
}