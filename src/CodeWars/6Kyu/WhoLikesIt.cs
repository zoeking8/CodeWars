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
				int count = name.Count();
				if (count > 1 && count < 3)
				{
					string s = Join(", ", name.Take(count - 2)
						.Concat(new[] { Join(" and ", name.Skip(count - 2)) }));
					return (s + " like this");
				}
				if (count > 3)
				{
					string s = Join(", ", name.Take(count + 3)
						.Concat(new[] { Join(" and ", name.Skip(count - 2)) }));
					return (s + " like this");
				}
				else
				{
					string s = Join(", ", name.Take(count - 2)
						.Concat(new[] { Join(" and ", name.Skip(count - 2)) }));
					return (s + " likes this");
				}
			}
		}
	}
}
