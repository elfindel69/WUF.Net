using System;


namespace WUF.Net.nations

{
    public class ViewConf
    {
		public static int MenuConf(System.Collections.Generic.List<Conf> confs)
		{
			Console.WriteLine("Confédérations :");
			for(int i = 0; i < confs.Count; i++)
            {
				Console.WriteLine(i+1+"- "+confs[i]);
            }
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
