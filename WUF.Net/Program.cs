using System;
using System.Collections.Generic;
using WUF.Net.competition;
using WUF.Net.matches;
using WUF.Net.nations;

namespace WUF.Net
{
    class Program
    {
        static void Main(string[] args)
        {
			ConsoleKeyInfo saisie;
			do
			{
				//menu principal
				int startMenu = ViewMenu.StartMenu();
				//scores
				if (startMenu == 1)
				{
					ContMenu.ExecScores();
				}
				//points
				if (startMenu == 2)
				{

					ContMenu.ExecPoints();
				}
				//nations
				if (startMenu == 3)
				{
					int confMenu = ViewConf.MenuConf();
					//Europe
					Conf europe = new Conf("Europe", "European", 54, "2018");
					ViewConf.DoViewConf(europe);
					TimeZoneInfo euZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
					if (confMenu == 1)
					{
						int natMenu = ViewNation.MenuNations();
						//France
						if (natMenu == 1)
						{
							Nation france = new Nation("France", 302.40, 0, europe, "Stade de France", "2018", 10, 3);
							ViewNation.DoViewNation(france);
							ViewCup.DoViewCup("World Cup", 0, "qualifications", "2021");
							string confCup = france.Conf.Adj + " Cup";
							ViewCup.DoViewCup(confCup, 1, "finalist", "2019");
							String confLeague = "League of Nations - " + france.Conf.Name;
							ViewLeague.DoViewLeague(confLeague, "1A", "N/A");
							char[] results = new char[5];
							for (int i = 0; i < results.Length; i++)
							{
								results[i] = 'V';
							}
							for (int i = 0; i < results.Length; i++)
							{
								Console.Write(results[i]);
							}
							Console.Write("\n\n");
							List<Match> tabMatches = new List<Match>();

							DateTime locDate1 = new DateTime(2020,03,06,20,00,00, DateTimeKind.Utc);
							tabMatches.Add(new Match("France", 18, "Albania", 9, locDate1));

							DateTime locDate2 = new DateTime(2020, 02, 12, 20, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("France", 23, "Cyprus", 9, locDate2));

							DateTime locDate3 = new DateTime(2020, 02, 07, 20, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("France", 23, "Israel", 9, locDate3));

							DateTime locDate4 = new DateTime(2020, 01, 08, 20, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("France", 23, "Moldova", 16, locDate4));

							DateTime locDate5 = new DateTime(2020, 01, 03, 20, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("France", 23, "Italy", 13, locDate5));

							foreach (Match item in tabMatches)
							{
								ViewMatches.DoViewMatches(item, euZone);
							}
						}

						//Italy
						if (natMenu == 2)
						{
							Nation italy = new Nation("Italy", 127.58, 0, europe, "Stadio Olympico", "2018", 31, 11);
							ViewNation.DoViewNation(italy);
							ViewCup.DoViewCup("World Cup", 0, "qualifications", "2021");
							String confCup = italy.Conf.Adj + " Cup";
							ViewCup.DoViewCup(confCup, 1, "quarter-finalist", "2019");
							String confLeague = "League of Nations - " + italy.Conf.Name;
							ViewLeague.DoViewLeague(confLeague, "2A", "N/A");
							char[] results = new char[5];
							results[0] = 'V';
							results[1] = 'V';
							results[2] = 'V';
							results[3] = 'V';
							results[4] = 'D';
							for (int i = 0; i < results.Length; i++)
							{
								Console.Write(results[i]);
							}
							Console.Write("\n\n");
							Match[] tabMatches = new Match[5];

							DateTime locDate1 = new DateTime(2020, 03, 06, 20, 00, 00, DateTimeKind.Utc);
							tabMatches[0] = new Match("Italy", 18, "Cyprus", 13, locDate1);

							DateTime locDate2 = new DateTime(2020, 02, 12, 20, 00, 00, DateTimeKind.Utc);
							tabMatches[1] = new Match("Italy", 18, "Albania", 9, locDate2);

							DateTime locDate3 = new DateTime(2020, 02, 07, 20, 00, 00, DateTimeKind.Utc);
							tabMatches[2] = new Match("Italy", 16, "Moldova", 9, locDate3);

							DateTime locDate4 = new DateTime(2020, 01, 08, 20, 00, 00, DateTimeKind.Utc);
							tabMatches[3] = new Match("Italy", 18, "Israel", 13, locDate4);

							DateTime locDate5 = new DateTime(2020, 01, 03, 20, 00, 00, DateTimeKind.Utc);
							tabMatches[4] = new Match("France", 23, "Italy", 13, locDate5);

							for (int i = 0; i < tabMatches.Length; i++)
							{
								ViewMatches.DoViewMatches(tabMatches[i], euZone);
							}
						}
					}

				}
				Console.WriteLine("Quitter ? y/n");
				saisie = Console.ReadKey(true);
			} while (saisie.Key != ConsoleKey.Y);

		}
	}
}
