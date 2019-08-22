using System.Text;

namespace CodeWars._8Kyu
{
	public class StringRepeatKata
	{
		public static string RepeatStr(int n, string s)
		{
			var output = new StringBuilder();

			for (var i = 0; i < n; i++) output.Append(s);

			return output.ToString();
		}
	}
}