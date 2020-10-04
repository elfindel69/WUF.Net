using System;
using System.Collections.Generic;

namespace WUF.Net.nations

{
    public class ViewConf
    {
		public static int MenuConf(List<string> lNames)
		{
			Console.WriteLine("Confederations:");
			int id = 1;
			foreach (string s in lNames)
			{
				Console.WriteLine(id + " - " + s);
				++id;
			}

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

        internal static Conf AddConf()
        {
			Console.WriteLine("New Confederation:");
			Console.WriteLine("name: " );
			string name = Console.ReadLine();
			Console.WriteLine("adj: ");
			string adj = Console.ReadLine();
			Console.WriteLine("date of creation: ");
			string year = Console.ReadLine();
			Console.WriteLine("nb of members: ");
			string sNb = Console.ReadLine();
			int.TryParse(sNb, out int nbMembers);

			return new Conf(name, adj, nbMembers, year);
		}
    }
}
