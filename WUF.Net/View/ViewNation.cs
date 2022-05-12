using System;

namespace WUF.Net.nations
{
    public class ViewNation
    {
		public static int MenuNations()
		{
			Console.WriteLine("Nations:");
			Console.WriteLine("1- France");
			Console.WriteLine("2- Italy");
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
	}
}
