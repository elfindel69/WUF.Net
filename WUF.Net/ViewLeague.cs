using MySql.Data.MySqlClient;
using System;


namespace WUF.Net.competition
{
    class ViewLeague
    {
        public static void DoViewLeague(League league)
        {
            Console.WriteLine(league.Name + " :");
            Console.WriteLine("current League: " + league.LLeague);
            Console.WriteLine("best result: " + league.Result + " - " + league.Year + "\n");
        }

        internal static League AddLeague(MySqlConnection conn)
        {
            Console.WriteLine("New League:");
            Console.WriteLine("name: ");
            string name = Console.ReadLine();
            Console.WriteLine("league: ");
            string league = Console.ReadLine();
            Console.WriteLine("Best result: ");
            string result = Console.ReadLine();
            Console.WriteLine("year: ");
            string year = Console.ReadLine();
            return new League(name, league, result, year);
        }
    }
}
