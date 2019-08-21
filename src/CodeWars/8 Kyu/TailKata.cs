using System;
namespace CodeWars
{
	public static class TailKata
	{
		public static bool CorrectTail(string body, string tail)
		{
			var sub = body.Substring(body.Length - (tail.Length));

			if (sub == tail)
				return true;
			else
				return false;
		}
	}
}