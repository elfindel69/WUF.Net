using System;
using System.Collections.Generic;

namespace WUF.Net.nations
{
    public class ViewNation
    {
		public static int MenuNations(List<Nation> nations)
		{
			Console.WriteLine("Nations:");
			for (int i = 0; i < nations.Count; i++)
            {
				Console.WriteLine(i + 1 + "- " + nations[i]);
            }
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}

		public static void DoViewNation(Nation nat)
		{
			Console.WriteLine("Nation :");
			Console.WriteLine("nom : " + nat.Name);
			Console.WriteLine("confédération : " + nat.Conf.Name);
			Console.WriteLine("date d'adhésion : " + nat.DoA);
			Console.WriteLine("stade principal : " + nat.Stadium);
			Console.WriteLine("Classement WUF : " + nat.RWuf);
			Console.WriteLine("Classement WUF " + nat.Conf.Name+" : " + nat.RConf);
			Console.WriteLine("points : " + nat.Pts);
		}

	}
}
