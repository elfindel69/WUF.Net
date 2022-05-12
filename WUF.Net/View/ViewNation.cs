using System;

namespace WUF.Net.nations
{
    public class ViewNation
    {
		public static int MenuNationsEurope()
		{
			Console.WriteLine("Nations:");
			Console.WriteLine("1- France");
			Console.WriteLine("2- Italie");
			Console.WriteLine("3- Angleterre");
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
