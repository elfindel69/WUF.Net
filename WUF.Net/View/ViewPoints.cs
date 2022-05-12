using System;
using WUF.Net.country;

namespace WUF.Net.points
{
    public class ViewPoints
    {
		public static int GetCoeff()
		{
			Console.WriteLine("Coeff");
			Console.WriteLine("20");
			Console.WriteLine("30");
			Console.WriteLine("40");
			Console.WriteLine("50");
			Console.WriteLine("60");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int coeff);

			return coeff;
		}

		public static void DoViewPoints(Country ct1, Country ct2)
		{
			Console.WriteLine("Pays 1:");
			Console.WriteLine("nom:" + ct1.Name);
			Console.WriteLine("points: " + ct1.Pts);
			Console.WriteLine("Pays 2:");
			Console.WriteLine("nom:" + ct2.Name);
			Console.WriteLine("points: " + ct2.Pts);
		}
	}
}
