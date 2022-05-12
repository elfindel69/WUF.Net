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
					
					if (confMenu == 1)
					{
						Conf europe = new Conf("Europe", "européen", 54, "2018");
						ViewConf.DoViewConf(europe);
						TimeZoneInfo euZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
						TimeZoneInfo ukZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
						int natMenu = ViewNation.MenuNationsEurope();
						//France
						if (natMenu == 1)
						{
							Nation france = new Nation("France", 1294.97, 0, europe, "Stade de France", "2018", 13, 6);
							ViewNation.DoViewNation(france);
							ViewCup.DoViewCup("Coupe du Monde", 1, "quarts de finale", "2021");
							string confCup = "Coupe d'Europe";
							ViewCup.DoViewCup(confCup, 1, "finaliste", "2019");
							String confLeague = "Ligue des Nations - Europe";
							ViewLeague.DoViewLeague(confLeague, "1A", "3");
							char[] results = new char[5];
							results[0] = 'D';
							results[1] = 'V';
							results[2] = 'D';
							results[3] = 'V';
							results[4] = 'D';
							for (int i = 0; i < results.Length; i++)
							{
								Console.Write(results[i]);
							}
							Console.Write("\n\n");
							List<Match> tabMatches = new List<Match>();
							
							DateTime locDate1 = new DateTime(2021,11,20,20,00,00, DateTimeKind.Utc);
							tabMatches.Add(new Match("Angleterre", 18, "France", 16, locDate1,euZone));

							DateTime locDate2 = new DateTime(2021, 11, 13, 20, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("Irlande", 14, "France", 16, locDate2, euZone));

							DateTime locDate3 = new DateTime(2021, 07, 09, 01, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("Nouvelle-Zélande", 85, "France", 51, locDate3, euZone));

							DateTime locDate4 = new DateTime(2021, 07, 02, 01, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("Croatie", 14, "France", 42, locDate4, euZone));

							DateTime locDate5 = new DateTime(2020, 06, 27, 01, 00, 00, DateTimeKind.Utc);
							tabMatches.Add(new Match("Afrique du Sud", 52, "France", 13, locDate5, euZone));

							france.Matches = tabMatches;

							foreach (Match item in france.Matches)
							{
								ViewMatches.DoViewMatches(item);
							}
						}

						//Italy
						if (natMenu == 2)
						{
							Nation italy = new Nation("Italie", 1153.25, 0, europe, "Stadio Olympico", "2018", 25, 10);
							ViewNation.DoViewNation(italy);
							ViewCup.DoViewCup("Coupe du Monde", 0, "qualifications", "2021");
							String confCup = "Coupe d'Europe";
							ViewCup.DoViewCup(confCup, 1, "quarts de finale", "2019");
							String confLeague = "Ligue des Nations - Europe";
							ViewLeague.DoViewLeague(confLeague, "2A", "3");
							char[] results = new char[5];
							results[0] = 'D';
							results[1] = 'V';
							results[2] = 'V';
							results[3] = 'V';
							results[4] = 'V';
							for (int i = 0; i < results.Length; i++)
							{
								Console.Write(results[i]);
							}
							Console.Write("\n\n");
							List<Match> tabMatches = new List<Match>();

							DateTime locDate1 = new DateTime(2020, 10, 23, 19, 00, 00, DateTimeKind.Utc);
							tabMatches[0] = new Match("Italie", 9, "Pays de Galles", 16, locDate1, euZone);

							DateTime locDate2 = new DateTime(2020, 10, 16, 19, 00, 00, DateTimeKind.Utc);
							tabMatches[1] = new Match("Croatie", 14, "Italie", 16, locDate2, euZone);

							DateTime locDate3 = new DateTime(2020, 09, 18, 19, 00, 00, DateTimeKind.Utc);
							tabMatches[2] = new Match("Italie", 16, "Russie", 14, locDate3, euZone);

							DateTime locDate4 = new DateTime(2020, 09, 11, 19, 00, 00, DateTimeKind.Utc);
							tabMatches[3] = new Match("Allemagne", 14, "Italie", 16, locDate4, euZone);

							DateTime locDate5 = new DateTime(2020, 08, 21, 19, 00, 00, DateTimeKind.Utc);
							tabMatches[4] = new Match("Suisse", 23, "Italie", 13, locDate5, euZone);

							italy.Matches = tabMatches;

							foreach (Match item in italy.Matches)
							{
								ViewMatches.DoViewMatches(item);
							}
						}
						//UK
						if(natMenu == 3)
                        {
							Nation england = new Nation("Angleterre", 1877.43, 0, europe, "Twickenham Stadium", "2018", 1, 1);
							ViewNation.DoViewNation(england);
							ViewCup.DoViewCup("Coupe du Monde", 1, "4eme", "2021");
							String confCup = england.Conf.Adj + " Cup";
							ViewCup.DoViewCup(confCup, 1, "vainqueur", "2019");
							String confLeague = "Ligue des Nations - Europe";
							ViewLeague.DoViewLeague(confLeague, "1A", "2");
							char[] results = new char[5];
							results[0] = 'D';
							results[1] = 'D';
							results[2] = 'V';
							results[3] = 'V';
							results[4] = 'V';
							for (int i = 0; i < results.Length; i++)
							{
								Console.Write(results[i]);
							}
							Console.Write("\n\n");
							List<Match> tabMatches = new List<Match>();

							DateTime locDate1 = new DateTime(2021, 07, 17, 01, 00, 00, DateTimeKind.Utc);
							tabMatches[0] = new Match("Angleterre", 38, "Afrique du Sud", 40, locDate1, ukZone);

							DateTime locDate2 = new DateTime(2020, 07, 13, 22, 30, 00, DateTimeKind.Utc);
							tabMatches[1] = new Match("Angleterre", 121, "Australie", 127, locDate2, ukZone);

							DateTime locDate3 = new DateTime(2020, 07, 07, 22, 30, 00, DateTimeKind.Utc);
							tabMatches[2] = new Match("Irlande", 15, "Angleterre", 55, locDate3, ukZone);

							DateTime locDate4 = new DateTime(2020, 06, 29, 01, 00, 00, DateTimeKind.Utc);
							tabMatches[3] = new Match("Angleterre", 105, "Hong Kong", 49, locDate4, ukZone);

							DateTime locDate5 = new DateTime(2020, 06, 26, 22, 30, 00, DateTimeKind.Utc);
							tabMatches[4] = new Match("Angleterre", 74, "Australie", 73, locDate5, ukZone);

							england.Matches = tabMatches;

							foreach (Match item in england.Matches)
							{
								ViewMatches.DoViewMatches(item);
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
