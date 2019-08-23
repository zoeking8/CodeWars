namespace CodeWars._7Kyu
{
	public class BabySharkLyricsGeneratorKata
	{
		public static string BabySharkLyrics()
		{
			string G="Grand",S=" shark",D=" doo",s="";
			foreach(var _ in new[]{"Baby"+S,"Mommy"+S,"Daddy"+S,G+"ma"+S,G+"pa"+S,"Let's go hunt"}) {
				var b=_+","+D+D+D+D+D+D+"\n";
				s+=b+b+b+_+"!\n";
			}
			return s+"Run away,…\n";
		}
	}
}
