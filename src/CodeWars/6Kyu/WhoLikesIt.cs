using System.Linq;
using static System.String;

namespace CodeWars._6Kyu
{
	public class WhoLikesIt
	{
		public static string Likes(string[] name)
		{
			if (name == null || name.Length == 0)
			{
				return "no one likes this";
			}
			else
			{
				var count = name.Length;
				if (count > 1 && count < 4)
				{
					var s = Join(", ", name.Take(count - 2)
						.Concat(new[] { Join(" and ", name.Skip(count - 2)) }));
					return (s + " like this");
				}
				if (count > 3)
				{
					var numberCount = count - 2;
					var s = Join(", ", name.Take(2)
					);
					return (s + " and " + numberCount +" others like this");
				}
				else
				{
					var s = Join(", ", name.Take(count - 2)
						.Concat(new[] { Join(" and ", name.Skip(count - 2)) }));
					return (s + " likes this");
				}
			}
		}
	}
}
