using System;


namespace WUF.Net.points
{
    public class CalcPoints
    {
		public static Points DoCalcPoints(double pts1, double pts2, int coeff, int diff)
		{
			double newPts1 = 0;
			double newPts2 = 0;

			// calcul de G
			double lDiff = CalcDiff(diff);

			// calcul de Delta
			double delta = pts1 - pts2;
			delta = delta / 400;
			delta = Math.Pow(10, delta) + 1;
			delta = 1 / delta;

			delta = delta * coeff * lDiff;

			// attribution des points
			if (diff > 0)
			{
				newPts1 = RoundToTwo(pts1 + delta);
				newPts2 = RoundToTwo(pts2 - delta);
			}
			if (diff == 0)
			{
				newPts1 = RoundToTwo(pts1 + delta);
				newPts2 = RoundToTwo(pts2 + delta);
			}
			if (diff < 0)
			{
				newPts1 = RoundToTwo(pts1 - delta);
				newPts2 = RoundToTwo(pts2 + delta);
			}



			Points points = new Points(newPts1, newPts2);

			return points;
		}

		private static double CalcDiff(int diff)
		{
			int lDiff = Math.Abs(diff);
			double res = 0;
			if (lDiff <= 5)
			{
				res = 1;
			}
			if (lDiff > 5 && lDiff <= 10)
			{
				res = 1.5;
			}
			if (lDiff > 10)
			{
				res = 1.75 + (lDiff - 3) / 8;
			}

			return res;
		}

		private static double RoundToTwo(double num)
		{
			return (double)Math.Round(num * 100d) / 100d;
		}
	}
}
