using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.country
{
    public class ViewCountry
    {
		public static Country NewCountry(bool scoreB)
		{
			Console.WriteLine("nom Pays");
			String name = Console.ReadLine();
			Console.WriteLine("points Pays");
			string strChoiceD = Console.ReadLine();
			double.TryParse(strChoiceD, out double pts);
			int scoreI = 0;
			if (scoreB)
			{

				Console.WriteLine("score Pays");
				string strChoiceI = Console.ReadLine();
				int.TryParse(strChoiceI, out scoreI);
			}
			return new Country(name, pts, scoreI);
		}
	}
}
