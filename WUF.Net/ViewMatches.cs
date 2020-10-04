using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.matches
{
    public class ViewMatches
    {
		public static void DoViewMatches(Match match)
		{
			Console.WriteLine(match.Nat1 + " vs " + match.Nat2);
			Console.WriteLine(match.Sc1 + " - " + match.Sc2);
			DateTime locDate = TimeZoneInfo.ConvertTime(match.DoM, match.TimeZone);
			string format = "yyyy-MM-dd HH:mm:ss tt\" GMT\"zzz";
			Console.WriteLine("date: " + locDate.ToString(format,new System.Globalization.CultureInfo("fr-FR")));
		}

        internal static Match AddMatch(MySqlConnection conn)
        {
            Console.WriteLine("New Match:");
            Console.WriteLine("nation 1: ");
            string nat1 = Console.ReadLine();
            Console.WriteLine("score 1: ");
            string sScore1 = Console.ReadLine();
            int.TryParse(sScore1, out int score1);
            Console.WriteLine("nation 2: ");
            string nat2 = Console.ReadLine();
            Console.WriteLine("score 2: ");
            string sScore2 = Console.ReadLine();
            int.TryParse(sScore2, out int score2);
            Console.WriteLine("date yyyy-MM-dd HH:mm:ss (French Time) :");
            string sDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(sDate, "yyyy-MM-dd HH:mm:ss",
                                System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("timeZone .Net :");
            string sTimeZone1 = Console.ReadLine();
            TimeZoneInfo timeZone1 = TimeZoneInfo.FindSystemTimeZoneById(sTimeZone1);
            Console.WriteLine("timeZone Java :");
            string sTimeZone2 = Console.ReadLine();
            return new Match(nat1, score1, nat2, score2, date,timeZone1, sTimeZone2);

        }
    }
}
