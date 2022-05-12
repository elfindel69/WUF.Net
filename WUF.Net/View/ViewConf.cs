using System;


namespace WUF.Net.nations

{
    public class ViewConf
    {
		public static int MenuConf()
		{
			Console.WriteLine("Confédérations :");
			Console.WriteLine("1- Europe");
			Console.WriteLine("2- Amériques");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}

		public static void DoViewConf(Conf conf)
		{
			Console.WriteLine("Confédération :");
			Console.WriteLine("nom : " + conf.Name);
			Console.WriteLine("affiliation: WUF");
			Console.WriteLine("sport: United Football");
			Console.WriteLine("date de création: " + conf.DoF);
			Console.WriteLine("nombre de membres: " + conf.NbMembers);

		}
	}
}
