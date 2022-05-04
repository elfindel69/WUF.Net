using System;
using WUF.Net.utils;

namespace WUF.Net.scores
{
    public class CalcScores
    {
		public static Scores DoCalcScores(double pts1, double pts2)
		{
			int score1;
			int score2;
			int rng1 = getRng(pts1-pts2);
			int rng2 = getRng(pts2-pts1);

			var rand = new Random();
			score1 = MyRandom.RNG5(rand, rng1) + MyRandom.RNG2(rand, rng1);
			score1 = fixScores(score1);

			score2 = MyRandom.RNG5(rand, rng2) + MyRandom.RNG2(rand, rng2);
			score2 = fixScores(score2);

			Scores scores = new Scores(score1, score2);

			return scores;
		}

		private static int fixScores(decimal pScore)
		{
			int rScore = 0;
			if (pScore == 1)
			{
				rScore = 2;
			}
			else if (pScore == 3 && pScore <= 5)
			{
				rScore = 2;
			}
			else
			{
				rScore = (int)Math.Floor(pScore);
			}

			return rScore;
		}

		private static int getRng(double pts)
		{
			int rng = 23;
			if (pts < -76 && pts >= -100)
			{
				rng = 20;
			}
			else if (pts < -51 && pts >= -75)
			{
				rng = 13;
			}
			else if (pts <-26 && pts >= -50)
			{
				rng = 8;
			}
			else if (pts <= 0 && pts >-25)
			{
				rng = 5;
			}
			else if (pts >= 0 && pts <= 25)
			{
				rng = 5;
			}
			else if (pts > 26 && pts <= 50)
			{
				rng = 8;
			}
			else if (pts > 51 && pts <= 75)
			{
				rng = 13;
			}
			else if (pts > 76 && pts <= 100)
			{
				rng = 20;
			}
			else if(pts>100)
			{
				rng = 23;
			}

			return rng;
		}
	}
}
