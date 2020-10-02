using System;


namespace WUF.Net.nations

{
    public class ViewConf
    {
		public static int MenuConf()
		{
			Console.WriteLine("Confederations:");
			Console.WriteLine("1- Europe");

			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}

		public static void DoViewConf(Conf conf)
		{
			Console.WriteLine("Confederation:");
			Console.WriteLine("name: " + conf.Name);
			Console.WriteLine("affiliation: WUF");
			Console.WriteLine("sport: United Football");
			Console.WriteLine("date of creation: " + conf.DoF);
			Console.WriteLine("nb of members: " + conf.NbMembers);

		}
	}
}
