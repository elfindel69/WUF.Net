using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.country;
using WUF.Net.points;
using WUF.Net.scores;

namespace WUF.Net
{
    class ContMenu
    {
		internal static void ExecScores()
		{
			Console.WriteLine("Scores !");
			Console.WriteLine("Pays 1:");
			Country ct1 = ViewCountry.NewCountry(false);
			Console.WriteLine("Pays 2:");

			Country ct2 = ViewCountry.NewCountry(false);
			Scores scores = CalcScores.DoCalcScores(ct1.Pts, ct2.Pts);
			ct1.Score = scores.Score1;
			ct2.Score = scores.Score2;
			ViewScores.DoViewScores(ct1, ct2);
		}

		internal static void ExecPoints()
		{
			Console.WriteLine("Points !");
			Console.WriteLine("Pays 1:");
			Country ct1 = ViewCountry.NewCountry(true);
			Console.WriteLine("Pays 2:");
			
			Country ct2 = ViewCountry.NewCountry(true);
			int coeff = ViewPoints.GetCoeff();
			int diff = ct1.Score - ct2.Score;
			Points points = CalcPoints.DoCalcPoints(ct1.Pts, ct2.Pts, coeff, diff);
			ct1.Pts = points.Pts1;
			ct2.Pts = points.Pts2;
			ViewPoints.DoViewPoints(ct1, ct2);
		}
	}
}
