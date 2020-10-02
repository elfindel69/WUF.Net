using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.matches
{
    public class ViewMatches
    {
		public static void DoViewMatches(Match match, TimeZoneInfo timeZone)
		{
			Console.WriteLine(match.Nat1 + " vs " + match.Nat2);
			Console.WriteLine(match.Sc1 + " - " + match.Sc2);
			DateTime locDate = TimeZoneInfo.ConvertTime(match.DoM, timeZone);
			string format = "yyyy-MM-dd HH:mm:ss tt\" GMT\"zzz";
			Console.WriteLine("date: " + locDate.ToString(format,new System.Globalization.CultureInfo("fr-FR")));
		}
	}
}
