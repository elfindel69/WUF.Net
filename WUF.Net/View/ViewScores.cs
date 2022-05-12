using System;
using WUF.Net.country;

namespace WUF.Net.scores
{
    public class ViewScores
    {
		public static void DoViewScores(Country ct1, Country ct2)
		{
			Console.WriteLine("Pays 1:");
			Console.WriteLine("nom:" + ct1.Name);
			Console.WriteLine("score: " + ct1.Score);
			Console.WriteLine("Pays 2:");
			Console.WriteLine("nom:" + ct2.Name);
			Console.WriteLine("score: " + ct2.Score);
		}
	}
}
