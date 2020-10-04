using MySql.Data.MySqlClient;
using Renci.SshNet.Security;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using WUF.Net.competition;
using WUF.Net.country;
using WUF.Net.matches;
using WUF.Net.nations;
using WUF.Net.points;
using WUF.Net.scores;

namespace WUF.Net
{
    class ContMenu
    {
		internal static void ExecScores()
		{
			Console.WriteLine("Scores !");
			Console.WriteLine("Pays 1:");
			Country ct1 = ViewCountry.NewCountry(false);
			Console.WriteLine("Pays 2:");

			Country ct2 = ViewCountry.NewCountry(false);
			Scores scores = CalcScores.DoCalcScores(ct1.Pts, ct2.Pts);
			ct1.Score = scores.Score1;
			ct2.Score = scores.Score2;
			ViewScores.DoViewScores(ct1, ct2);
		}

		internal static void ExecPoints()
		{
			Console.WriteLine("Points !");
			Console.WriteLine("Pays 1:");
			Country ct1 = ViewCountry.NewCountry(true);
			Console.WriteLine("Pays 2:");
			
			Country ct2 = ViewCountry.NewCountry(true);
			int coeff = ViewPoints.GetCoeff();
			int diff = ct1.Score - ct2.Score;
			Points points = CalcPoints.DoCalcPoints(ct1.Pts, ct2.Pts, coeff, diff);
			ct1.Pts = points.Pts1;
			ct2.Pts = points.Pts2;
			ViewPoints.DoViewPoints(ct1, ct2);
		}

		internal static void AddMatch(MySqlConnection conn)
		{
			Match newMatch = ViewMatches.AddMatch(conn);
			int lines = ContMatches.InsertMatch(conn, newMatch);
			if (lines == 1)
			{
				Console.WriteLine("insertion successful !");
			}
			else
			{
				Console.WriteLine("insertion error !");
			}
		}

		internal static void ViewNations(MySqlConnection conn)
		{
			List<string> lNames = ContConf.GetConfNames(conn);
			int confMenu = ViewConf.MenuConf(lNames);
			int confId = confMenu - 1;

			//Confederation
			List<Conf> lConf = ContConf.GetConfData(conn, lNames[confId]);
			foreach (Conf c in lConf) {
				ViewConf.DoViewConf(c);
			}
			if (confMenu > 1) {
				++confMenu;
			}
			List<String> lNatNames = ContNation.GetNatNames(conn, confMenu);
			
			if(lNatNames.Count > 0)
			{
				int natMenu = ViewNation.MenuNations(lNatNames);
				int natId = 0;
				if (natMenu > 0)
				{
					natId = natMenu - 1;
				}


				//Nation

				List<Nation> lNat = ContNation.GetNatData(conn, lNatNames[natId]);
				Nation nat = lNat[0];
				nat.Conf = lConf[0];

				List<Cup> lCups = ContCup.GetCupData(conn, lNatNames[natId]);

				List<League> lLeagues = ContLeague.GetLeagueData(conn, lNatNames[natId]);
				League confLeague = null;
				if (lLeagues != null && lLeagues.Count > 0)
				{
					confLeague = lLeagues[0];
				}


				List<Match> tabMatches = ContMatches.GetMatchesData(conn, lNatNames[natId]);

				char[] results = ContMatches.CalcResults(tabMatches, lNatNames[natId]);

				NatPage natPage = new NatPage(nat, lCups, confLeague, tabMatches, results);
				ViewNatPage.ViewPage(natPage);
				Console.WriteLine("Continuer: Y/N");
				ConsoleKeyInfo saisie = Console.ReadKey(true);
				if (saisie.Key == ConsoleKey.N)
				{
					return;
				}
				//add Cup
				Console.WriteLine("Ajout Coupe");
				AddCup(conn, nat.Name);
				Console.WriteLine("Continuer: Y/N");
				saisie = Console.ReadKey(true);
				if (saisie.Key == ConsoleKey.N)
				{
					return;
				}
				//add League
				Console.WriteLine("Ajout Ligue");
				AddLeague(conn, nat.Name);
			}
		}

		internal static void AddConf(MySqlConnection conn)
		{

			Console.WriteLine("Ajout conf: ");
			Conf newConf = ViewConf.AddConf();
			int lines = ContConf.InsertConf(conn, newConf);
			if (lines == 1)
			{
				Console.WriteLine("insertion successful !");
			}
			else
			{
				Console.WriteLine("insertion error !");
			}
		}
		internal static void AddNation(MySqlConnection conn)
		{

			Console.WriteLine("Ajout nation: ");
			Nation newNat = ViewNation.AddNation(conn);
			int lines = ContNation.InsertNation(conn, newNat);
			if (lines == 1)
			{
				Console.WriteLine("insertion successful !");
			}
			else
			{
				Console.WriteLine("insertion error !");
			}
			Console.WriteLine("Continuer: Y/N");
			ConsoleKeyInfo saisie = Console.ReadKey(true);
			if (saisie.Key == ConsoleKey.N)
			{
				return;
			}
			//add Cup
			Console.WriteLine("Ajout Coupe");
			AddCup(conn, newNat.Name);
			Console.WriteLine("Continuer: Y/N");
			saisie = Console.ReadKey(true);
			if (saisie.Key == ConsoleKey.N)
			{
				return;
			}
			//add League
			Console.WriteLine("Ajout Ligue");
			AddLeague(conn, newNat.Name);
		}

		internal static void AddCup(MySqlConnection conn, string nation)
		{
			Cup newCup = ViewCup.AddCup(conn);
			int lines = ContCup.InsertCup(conn, nation, newCup);
			if (lines == 1)
			{
				Console.WriteLine("insertion successful !");
			}
			else
			{
				Console.WriteLine("insertion error !");
			}
		}

		internal static void AddLeague(MySqlConnection conn, string nation)
		{
			League newLeague = ViewLeague.AddLeague(conn);
			int lines = ContLeague.InsertLeague(conn, nation, newLeague);
			if (lines == 1)
			{
				Console.WriteLine("insertion successful !");
			}
			else
			{
				Console.WriteLine("insertion error !");
			}
		}

	}
}
