using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;

namespace WUF.Net.nations
{
    public class ViewNation
    {
		public static int MenuNations(List<string> lNat)
		{
			Console.WriteLine("Nations:");
			int id = 1;
			foreach (string s in lNat)
			{
				Console.WriteLine(id + " - " + s);
				++id;
			}
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}

		public static void DoViewNation(Nation nat)
		{
			Console.WriteLine("Nation:");
			Console.WriteLine("name: " + nat.Name);
			Console.WriteLine("confederation: " + nat.Conf.Name);
			Console.WriteLine("date of adhesion: " + nat.DoA);
			Console.WriteLine("main stadium: " + nat.Stadium);
			Console.WriteLine("WUF Ranking: " + nat.RWuf);
			Console.WriteLine("WUF " + nat.Conf.Name + " Ranking: " + nat.RConf);
			Console.WriteLine("points: " + nat.Pts);
		}


		internal static Nation AddNation(MySqlConnection conn)
        {
			Console.WriteLine("New Nation:");
			Console.WriteLine("name: ");
			string name = Console.ReadLine();
			Console.WriteLine("points: ");
			string sPts = Console.ReadLine();
			double.TryParse(sPts, out double pts);
			List<string> lNames = ContConf.GetConfNames(conn);
			int confMenu = ViewConf.MenuConf(lNames);
			int confId = confMenu - 1;

			//Confederation
			List<Conf> lConf = ContConf.GetConfData(conn, lNames[confId]);
			Conf conf = lConf[0];
			if (confMenu > 1)
			{
				++confMenu;
			}
			conf.ConfId = confMenu;
			Console.WriteLine("date of adhesion: ");
			string year = Console.ReadLine();
			Console.WriteLine("stadium: ");
			string stadium = Console.ReadLine();
			Console.WriteLine("WUF Ranking:");
			string sWuf = Console.ReadLine();
			int.TryParse(sWuf, out int rWuf);
			Console.WriteLine("Conf Ranking:");
			string sConf = Console.ReadLine();
			int.TryParse(sConf, out int rConf);


			return new Nation(name, pts, conf,stadium, year, rWuf, rConf);
		}
    }
}
